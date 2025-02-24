using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProject
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CacheResultAttribute : Attribute { }

    public class ExpensiveOperations
    {
        private static Dictionary<int, long> cache = new Dictionary<int, long>();

        [CacheResult]
        public long Fibonacci(int n)
        {
            if (cache.ContainsKey(n))
                return cache[n];

            long result = n <= 1 ? n : Fibonacci(n - 1) + Fibonacci(n - 2);
            cache[n] = result;
            return result;
        }
    }
    class CustomCachingSystem
    {
        static void Main()
        {
            ExpensiveOperations operations = new ExpensiveOperations();
            Console.WriteLine(operations.Fibonacci(30)); // Will compute
            Console.WriteLine(operations.Fibonacci(30)); // Will return cached result
        }
    }
}
