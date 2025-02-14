using System;

class MergeSortAlgo
{
    static void Merge(int[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = prices[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = prices[mid + 1 + j];

        int x = 0, y = 0, k = left;
        while (x < n1 && y < n2)
        {
            if (leftArray[x] <= rightArray[y])
                prices[k++] = leftArray[x++];
            else
                prices[k++] = rightArray[y++];
        }
        while (x < n1) prices[k++] = leftArray[x++];
        while (y < n2) prices[k++] = rightArray[y++];
    }
    static void MergeSort(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);
            Merge(prices, left, mid, right);
        }
    }

    static void Main()
    {
        int[] prices = { 299, 150, 499, 199, 350 };
        Console.WriteLine("Original Book Prices: " + string.Join(", ", prices));
        MergeSort(prices, 0, prices.Length - 1);
        Console.WriteLine("Sorted Book Prices: " + string.Join(", ", prices));
    }
}
