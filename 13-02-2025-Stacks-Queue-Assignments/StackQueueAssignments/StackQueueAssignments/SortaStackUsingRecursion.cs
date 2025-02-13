using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueAssignments
{
    internal class SortaStackUsingRecursion
    {
        static void SortedInsert(Stack<int> stack, int num)
        {
            if (stack.Count == 0 || stack.Peek() <= num)
            {
                stack.Push(num);
                return;
            }

            int top = stack.Pop();
            SortedInsert(stack, num);
            stack.Push(top);
        }

        // Recursive function to sort the stack
        static void SortStack(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int top = stack.Pop();
                SortStack(stack);
                SortedInsert(stack, top);
            }
        }
        static void PrintStack(Stack<int> stack)
        {
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(30);
            stack.Push(-5);
            stack.Push(18);
            stack.Push(14);
            stack.Push(-3);

            Console.WriteLine("Original Stack:");
            PrintStack(stack);

            SortStack(stack);

            Console.WriteLine("\nSorted Stack:");
            PrintStack(stack);
        }
    }
}
