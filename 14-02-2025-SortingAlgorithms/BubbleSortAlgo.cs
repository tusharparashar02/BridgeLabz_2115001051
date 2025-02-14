using System;

class BubbleSortAlgo
{
    static void BubbleSort(int[] marks)
    {
        int n = marks.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    // Swap
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
    static void Main()
    {
        int[] marks = { 85, 83, 98, 60, 78 };
        Console.WriteLine("Original Marks: " + string.Join(", ", marks));
        BubbleSort(marks);
        Console.WriteLine("Sorted Marks: " + string.Join(", ", marks));
    }
}
