using System;

class CountingSortAlgo
{
    static void CountingSort(int[] ages, int minAge, int maxAge)
    {
        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];

        for (int i = 0; i < ages.Length; i++)
            count[ages[i] - minAge]++;

        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }
        for (int i = 0; i < ages.Length; i++)
            ages[i] = output[i];
    }

    static void Main()
    {
        int[] ages = { 15, 12, 18, 10, 14, 17, 11 };
        Console.WriteLine("Original Ages: " + string.Join(", ", ages));
        CountingSort(ages, 10, 18);
        Console.WriteLine("Sorted Ages: " + string.Join(", ", ages));
    }
}
