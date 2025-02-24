using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProject
{
    //LogExecutionTime attribute
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    class LogExecutionTimeAttribute : Attribute
    {
    }

    //Applying the attribute to methods
    class PerformanceTester
    {
        [LogExecutionTime]
        public void FastMethod()
        {
            for (int i = 0; i < 100000; i++) { } // Simulating quick execution
        }

        [LogExecutionTime]
        public void SlowMethod()
        {
            System.Threading.Thread.Sleep(500); // Simulating a slow operation
        }
    }
    class AttributeforLoggingMethod
    {
        public static void Main()
        {
            Type type = typeof(PerformanceTester);
            object instance = Activator.CreateInstance(type);
            MethodInfo[] methods = type.GetMethods();

            foreach (var method in methods)
            {
                if (Attribute.IsDefined(method, typeof(LogExecutionTimeAttribute)))
                {
                    Stopwatch stopwatch = Stopwatch.StartNew();

                    method.Invoke(instance, null); // Execute method

                    stopwatch.Stop();
                    Console.WriteLine($"Method: {method.Name}, Execution Time: {stopwatch.ElapsedMilliseconds} ms");
                }
            }
        }
    }
}
