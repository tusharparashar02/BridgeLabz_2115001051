using System;
using System.Diagnostics;
class SortingLargeData
{
        public static void Main()
        {
            int[] sizes = { 1000, 10000, 100000 };
            Random r = new Random();

            foreach (int size in sizes)
            {
                int[] data1 = new int[size];

                for(int i=0; i<size; i++)
                {
                    data1[i] = r.Next(1, size * 10);
                }
                int[] data2 = (int[])data1.Clone();
                int[] data3 = (int[])data1.Clone();

                // Bubble Sort
                Stopwatch sw = Stopwatch.StartNew();
                BubbleSort(data1);
                sw.Stop();
                Console.WriteLine($"Bubble Sort N={size}: {sw.Elapsed.TotalMilliseconds}ms");

                // Merge Sort
                sw.Restart();
                MergeSort(data2, 0, data2.Length - 1);
                sw.Stop();
                Console.WriteLine($"Merge Sort N={size}: {sw.Elapsed.TotalMilliseconds}ms");

                // Quick Sort
                sw.Restart();
                QuickSort(data3, 0, data3.Length - 1);
                sw.Stop();
                Console.WriteLine($"Quick Sort N={size}: {sw.Elapsed.TotalMilliseconds}ms");
                Console.WriteLine();
            }
        }

        //Bubble sort
        static void BubbleSort(int[] data)
        {
            int n = data.Length;
            if(n>10000)
            {
                Console.WriteLine("Bubble sort is not feasible for large dataset");
                return;
            }
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (data[j] > data[j + 1])
                        (data[j], data[j + 1]) = (data[j + 1], data[j]);
        }

        //Merge sort
        static void MergeSort(int[] data, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(data, left, mid);
                MergeSort(data, mid + 1, right);
                Merge(data, left, mid, right);
            }
        }

        static void Merge(int[] data, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1], R = new int[n2];

            Array.Copy(data, left, L, 0, n1);
            Array.Copy(data, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
                data[k++] = (L[i] <= R[j]) ? L[i++] : R[j++];
            while (i < n1)
                data[k++] = L[i++];
            while (j < n2)
                data[k++] = R[j++];
        }

        //Quick sort
        static void QuickSort(int[] data, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(data, low, high);
                QuickSort(data, low, pi - 1);
                QuickSort(data, pi + 1, high);
            }
        }

        static int Partition(int[] data, int low, int high)
        {
            int pivot = data[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (data[j] < pivot)
                {
                    i++;
                    (data[i], data[j]) = (data[j], data[i]);
                }
            }
            (data[i + 1], data[high]) = (data[high], data[i + 1]);
            return i + 1;
        }
    }