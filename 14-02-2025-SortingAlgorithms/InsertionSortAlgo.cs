using System;

class InsertionSortAlgo
{
    static void InsertionSort(int[] empIds)
    {
        int n = empIds.Length;
        for (int i = 1; i < n; i++)
        {
            int key = empIds[i];
            int j = i - 1; 
            while (j >= 0 && empIds[j] > key)
            {
                empIds[j + 1] = empIds[j];
                j--;
            }
            empIds[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] empIds = { 14, 12, 11, 15, 13 };
        Console.WriteLine("Original Employee IDs: " + string.Join(", ", empIds));
        InsertionSort(empIds);
        Console.WriteLine("Sorted Employee IDs: " + string.Join(", ", empIds));
    }
}
