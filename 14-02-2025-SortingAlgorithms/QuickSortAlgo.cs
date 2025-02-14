using System;

class QuickSortAlgo
{
    static int Partition(int[] prices, int low, int high)
    {
        int pivot = prices[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (prices[j] < pivot)
            {
                i++;
                (prices[i], prices[j]) = (prices[j], prices[i]);
            }
        }
        (prices[i + 1], prices[high]) = (prices[high], prices[i + 1]);
        return i + 1;
    }

    static void QuickSort(int[] prices, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(prices, low, high);
            QuickSort(prices, low, pi - 1);
            QuickSort(prices, pi + 1, high);
        }
    }

    static void Main()
    {
        int[] prices = { 799, 299, 499, 199, 999 };
        Console.WriteLine("Original Product Prices: " + string.Join(", ", prices));
        QuickSort(prices, 0, prices.Length - 1);
        Console.WriteLine("Sorted Product Prices: " + string.Join(", ", prices));
    }
}
