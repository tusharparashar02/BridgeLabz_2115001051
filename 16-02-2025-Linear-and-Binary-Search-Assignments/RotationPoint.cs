using System;
class RotationPoint
{
     public static int FindRotationPoint(int[] nums)
        {
            int l = 0, r = nums.Length - 1;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] > nums[r])
                    l = mid + 1;
                else
                    r = mid;
            }
            return l;
        }
        public static void Main()
        {
            int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
            int index = FindRotationPoint(arr);
            Console.WriteLine("Rotation point index: " + index);
        }

}