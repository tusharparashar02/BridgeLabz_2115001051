using System;
class MissingPositiveInteger
{
   
        static int FindFirstMissingPositive(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
                {
                    int temp = nums[i];
                    (nums[i],nums[temp - 1]) = (nums[temp - 1], nums[i]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != i + 1)
                {
                    return i + 1;
                }
            }
            return n + 1;
        }

        static int BinarySearch(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
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
            return -1;
        }

        public static void Main()
        {
            int[] arr1 = { 3, 4, -1, 1 };
            int missing = FindFirstMissingPositive(arr1);
            Console.WriteLine("First missing positive integer: " + missing);

            int[] arr2 = { 1, 2, 2, 2, 3, 4, 5 };
            int searchTarget = 2;
            int searchIndex = BinarySearch(arr2, searchTarget);
            Console.WriteLine("Target index: " + searchIndex);
        }
    }
