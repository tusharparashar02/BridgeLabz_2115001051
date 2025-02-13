using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueAssignments
{
    internal class TwoSumProblem
    {
        static int[] TwoSum(int[] arr, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (map.ContainsKey(complement))
                    return new int[] { map[complement], i };

                map[arr[i]] = i;
            }

            return new int[] { -1, -1 };  // No pair found
        }

        static void Main()
        {
            int[] arr = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSum(arr, target);
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }
    }
}
