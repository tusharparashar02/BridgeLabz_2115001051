using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
class InterThreadCommunication
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out))
        {
            Thread writerThread = new Thread(() =>
            {
                using (StreamWriter writer = new StreamWriter(pipeServer))
                {
                    writer.AutoFlush = true;
                    for (int i = 1; i <= 5; i++)
                    {
                        writer.WriteLine("Message " + i);
                        Thread.Sleep(500);
                    }
                }
            });

            using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle))
            {
                Thread readerThread = new Thread(() =>
                {
                    using (StreamReader reader = new StreamReader(pipeClient))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine("Received: " + line);
                        }
                    }
                });

                writerThread.Start();
                readerThread.Start();
                writerThread.Join();
                readerThread.Join();
            }
        }
    }
}
