using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionProject
{
    class Calculator
    {
        private int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    public class InvokePrivateMethod
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            Type type = typeof(Calculator);

            MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

            object result = method.Invoke(calc, new object[] { 5, 3 });
            Console.WriteLine($"Multiplication Result: {result}");
        }
    }
}
