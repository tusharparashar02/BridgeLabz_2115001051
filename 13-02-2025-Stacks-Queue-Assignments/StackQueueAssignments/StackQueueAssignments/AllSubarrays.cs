using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueAssignments
{
    internal class AllSubarrays
    {
        static void FindZeroSumSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (sum == 0)
                    Console.WriteLine($"Subarray found: (0, {i})");

                if (map.ContainsKey(sum))
                {
                    foreach (int index in map[sum])
                        Console.WriteLine($"Subarray found: ({index + 1}, {i})");
                }

                if (!map.ContainsKey(sum))
                    map[sum] = new List<int>();

                map[sum].Add(i);
            }
        }

        static void Main()
        {
            int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
            FindZeroSumSubarrays(arr);
        }
    }
}
