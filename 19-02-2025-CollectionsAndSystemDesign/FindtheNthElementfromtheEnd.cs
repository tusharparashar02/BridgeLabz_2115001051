using System;
using System.Collections.Generic;

class FindtheNthElementfromtheEnd
{
    static string FindNthFromEnd(LinkedList<string> list, int n)
    {
        var first = list.First;
        var second = list.First;

        for (int i = 0; i < n; i++)
        {
            if (second == null) return "N is greater than list size";
            second = second.Next;
        }

        while (second != null)
        {
            first = first.Next;
            second = second.Next;
        }

        return first.Value;
    }

    static void Main()
    {
        LinkedList<string> letters = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });
        Console.WriteLine(FindNthFromEnd(letters, 2));
    }
}
