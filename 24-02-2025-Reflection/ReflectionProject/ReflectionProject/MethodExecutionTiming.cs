using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace ReflectionProject
{
    class PerformanceAnalyzer
    {
        public static void MeasureExecutionTime(object obj, string methodName, object[] parameters)
        {
            Type type = obj.GetType();
            MethodInfo method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (method == null)
            {
                Console.WriteLine("Method not found!");
                return;
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            method.Invoke(obj, parameters);
            stopwatch.Stop();

            Console.WriteLine($"{methodName} executed in {stopwatch.ElapsedMilliseconds} ms");
        }
    }

    class TestClass
    {
        public void SlowMethod()
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("SlowMethod executed.");
        }

        public void FastMethod()
        {
            Console.WriteLine("FastMethod executed.");
        }
    }
    class MethodExecutionTiming
    {
        static void Main()
        {
            TestClass obj = new TestClass();

            PerformanceAnalyzer.MeasureExecutionTime(obj, "SlowMethod", new object[] { });
            PerformanceAnalyzer.MeasureExecutionTime(obj, "FastMethod", new object[] { });
        }
    }
}
