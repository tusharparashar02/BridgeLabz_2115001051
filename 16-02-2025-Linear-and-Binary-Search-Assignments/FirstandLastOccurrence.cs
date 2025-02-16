using System;
class FirstandLastOccurrence
{
        public static int[] FindFirstAndLastOccurrence(int[] nums, int target)
        {
            int first = -1, last = -1;
            int left = 0, right = nums.Length - 1;

            //first occurrence
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    first = mid;
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            left = 0;
            right = nums.Length - 1;

            //last occurrence
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    last = mid;
                    left = mid + 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return new int[] { first, last };
        }

        public static void Main()
        {
            int[] sortedArr = { 1, 2, 2, 2, 3, 4, 5 };
            int[] result = FindFirstAndLastOccurrence(sortedArr, 2);
            Console.WriteLine("First occurrence: " + result[0] + ", Last occurrence: " + result[1]);
        }
    }
