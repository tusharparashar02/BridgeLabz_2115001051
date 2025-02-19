using System;
using System.Collections.Generic;

class RotateElementsinaList
{
    static void RotateList(List<int> list, int k)
    {
        int n = list.Count;
        k = k % n;
        List<int> rotated = new List<int>();

        for (int i = k; i < n; i++)
            rotated.Add(list[i]);

        for (int i = 0; i < k; i++)
            rotated.Add(list[i]);

        list.Clear();
        list.AddRange(rotated);
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        RotateList(numbers, 2);
        Console.WriteLine(string.Join(", ", numbers));
    }
}
