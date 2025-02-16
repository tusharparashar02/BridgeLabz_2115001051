using System;
using System.Text;

class CompareStringBuilderPerformance
{
    static void Main()
    {
        long startTime, endTime;
        // Testing String Performance
        startTime = DateTime.Now.Ticks;
        string str = "Tushar";
        for (int i = 0; i < 100000; i++)
        {
            str += " Performance Test";
        }
        endTime = DateTime.Now.Ticks;
        Console.WriteLine("String Time: " + (endTime - startTime) + " ticks");

        // Testing StringBuilder Performance
        startTime = DateTime.Now.Ticks;
        StringBuilder sb = new StringBuilder("Tushar");
        for (int i = 0; i < 100000; i++)
        {
            sb.Append(" Performance Test");
        }
        endTime = DateTime.Now.Ticks;
        Console.WriteLine("StringBuilder Time: " + (endTime - startTime) + " ticks");
    }
}
