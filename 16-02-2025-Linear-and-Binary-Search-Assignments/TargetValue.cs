using System;
class TargetValue
{
    public static bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int left = 0, right = rows * cols - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midValue = matrix[mid / cols, mid % cols];

                if (midValue == target)
                {
                    return true;
                }
                else if (midValue < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }

        public static void Main()
        {
            int[,] matrix = {{1, 3, 4, 6},{18, 10, 17, 20},{23, 32, 34, 90}};
            int target = 17;
            bool found = SearchMatrix(matrix, target);
            Console.WriteLine("Target found: " + found);
        }
}
