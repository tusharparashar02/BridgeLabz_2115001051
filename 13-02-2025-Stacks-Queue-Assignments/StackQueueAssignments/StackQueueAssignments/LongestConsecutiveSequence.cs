using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueAssignments
{
    internal class LongestConsecutiveSequence
    {
        static int LongestConsecutive(int[] arr)
        {
            HashSet<int> numSet = new HashSet<int>(arr);
            int longestStreak = 0;

            foreach (int num in arr)
            {
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }

        static void Main()
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine("Longest Consecutive Sequence Length: " + LongestConsecutive(arr));
        }
    }
}
