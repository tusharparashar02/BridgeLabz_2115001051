using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionProject
{
    class MathOperations
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
    }
    public class DynamicMethodInvocation
    {
        static void Main()
        {
            MathOperations math = new MathOperations();
            Type type = typeof(MathOperations);

            Console.Write("Enter method name (Add, Subtract, Multiply): ");
            string methodName = Console.ReadLine();

            MethodInfo method = type.GetMethod(methodName);
            if (method == null)
            {
                Console.WriteLine("Method not found!");
                return;
            }

            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            object result = method.Invoke(math, new object[] { num1, num2 });
            Console.WriteLine($"Result: {result}");
        }
    }
}
