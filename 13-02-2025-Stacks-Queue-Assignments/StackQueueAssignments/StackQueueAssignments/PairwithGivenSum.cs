using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueAssignments
{
    internal class PairwithGivenSum
    {
        static bool HasPairWithSum(int[] arr, int target)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in arr)
            {
                int complement = target - num;
                if (seen.Contains(complement))
                {
                    Console.WriteLine($"Pair found: ({num}, {complement})");
                    return true;
                }
                seen.Add(num);
            }

            return false;
        }

        static void Main()
        {
            int[] arr = { 1, 4, 7, 3, 9 };
            int target = 10;
            Console.WriteLine(HasPairWithSum(arr, target));
        }
    }
}
