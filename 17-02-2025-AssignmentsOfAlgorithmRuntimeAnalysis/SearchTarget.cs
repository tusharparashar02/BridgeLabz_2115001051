using System;
using System.Diagnostics;
class SearchTarget
{
       public static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };
            Random r = new Random();

            foreach (int size in sizes)
            {
                int[] data = new int[size];
                for (int i = 0; i < size; i++)
                    data[i] = r.Next(1, size * 10);

                int target = data[r.Next(size)];

                // Linear Search
                Stopwatch sw = Stopwatch.StartNew();
                LinearSearch(data, target);
                sw.Stop();
                Console.WriteLine($"Linear Search N={size}: {sw.Elapsed.TotalMilliseconds}ms");

                // Sort Data for Binary Search
                Array.Sort(data);

                // Binary Search
                sw.Restart();
                BinarySearch(data, target);
                sw.Stop();
                Console.WriteLine($"Binary Search N={size}: {sw.Elapsed.TotalMilliseconds}ms");
                Console.WriteLine();
            }
        }

        //Linear Search
        static int LinearSearch(int[] data, int target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                    return i;
            }
            return -1;
        }

        //Binary Search
        static int BinarySearch(int[] data, int target)
        {
            int left = 0, right = data.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (data[mid] == target)
                    return mid;
                else if (data[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
