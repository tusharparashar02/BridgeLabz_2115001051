using System;

class HeapSortAlgo
{
    static void Heapify(int[] salaries, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && salaries[left] > salaries[largest])
            largest = left;

        if (right < n && salaries[right] > salaries[largest])
            largest = right;

        if (largest != i)
        {
            (salaries[i], salaries[largest]) = (salaries[largest], salaries[i]);
            Heapify(salaries, n, largest);
        }
    }

    static void HeapSort(int[] salaries)
    {
        int n = salaries.Length;

        // Build heap (rearrange array)
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(salaries, n, i);

        // Extract elements one by one
        for (int i = n - 1; i > 0; i--)
        {
            (salaries[0], salaries[i]) = (salaries[i], salaries[0]);
            Heapify(salaries, i, 0);
        }
    }

    static void Main()
    {
        int[] salaries = { 500, 600, 450, 750, 550 };
        Console.WriteLine("Original Salaries: " + string.Join(", ", salaries));
        HeapSort(salaries);
        Console.WriteLine("Sorted Salaries: " + string.Join(", ", salaries));
    }
}
