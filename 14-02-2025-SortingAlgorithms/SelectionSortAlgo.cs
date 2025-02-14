using System;

class SelectionSortAlgo
{
    static void SelectionSort(int[] scores)
    {
        int n = scores.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                    minIndex = j;
            }

            (scores[minIndex], scores[i]) = (scores[i], scores[minIndex]);
        }
    }

    static void Main()
    {
        int[] scores = { 75, 90, 65, 85, 80 };
        Console.WriteLine("Original Exam Scores: " + string.Join(", ", scores));
        SelectionSort(scores);
        Console.WriteLine("Sorted Exam Scores: " + string.Join(", ", scores));
    }
}
