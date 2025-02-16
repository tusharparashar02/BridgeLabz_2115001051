using System;
class PeakElementinanArray
{
     public static int FindPeakElement(int[] nums)
        {
            int l = 0, r = nums.Length - 1;

            while (l < r)
            {
                int mid = l + (r - l) / 2;

                if (nums[mid] > nums[mid + 1])
                    return mid;

                else
                    l = mid + 1;
            }
            return l;
        }

        public static void Main()
        {
            int[] arr = { 1, 3, 20, 4, 1, 0 };
            int index = FindPeakElement(arr);
            Console.WriteLine("Peak element index: " + index);
        }
}