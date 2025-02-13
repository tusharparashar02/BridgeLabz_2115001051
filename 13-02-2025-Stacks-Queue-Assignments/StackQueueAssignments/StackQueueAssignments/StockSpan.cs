using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueAssignments
{
    internal class StockSpan
    {
        static int[] CalculateStockSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

                span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
                stack.Push(i);
            }

            return span;
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };

            Console.WriteLine("Stock Prices:");
            PrintArray(prices);

            int[] span = CalculateStockSpan(prices);

            Console.WriteLine("\nStock Span:");
            PrintArray(span);
        }
    }
}
