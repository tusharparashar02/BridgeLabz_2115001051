using System;
using System.Diagnostics;
using System.Text;
class StringConcatenation
{
        public static void Main()
        {
            int[] sizes = { 1000, 10000, 100000 };

            foreach (int iterations in sizes)
            {

                // Using string
                Stopwatch sw = Stopwatch.StartNew();
                string str = "";
                for (int i = 0; i < iterations; i++)
                {
                    str += "a";
                }
                sw.Stop();
                Console.WriteLine($"String Concatenation N={iterations}: {sw.Elapsed.TotalMilliseconds}ms");

                // Using StringBuilder
                sw.Restart();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < iterations; i++)
                {
                    sb.Append("a");
                }
                sw.Stop();
                Console.WriteLine($"StringBuilder Concatenation N={iterations}: {sw.Elapsed.TotalMilliseconds}ms");
                Console.WriteLine();
            }
        }
    }