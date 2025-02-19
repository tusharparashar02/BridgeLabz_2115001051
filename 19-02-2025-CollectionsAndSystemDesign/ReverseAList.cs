using System;
using System.Collections;
using System.Collections.Generic;
class ReverseAList
{
    static void ReverseArrayList(ArrayList list)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }

    static void ReverseLinkedList(LinkedList<int> list)
    {
        LinkedList<int> tempList = new LinkedList<int>();
        foreach (var item in list)
            tempList.AddFirst(item);
        
        list.Clear();
        foreach (var item in tempList)
            list.AddLast(item);
    }

    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 5 };
        ReverseArrayList(arrayList);
        Console.WriteLine(string.Join(", ", arrayList));

        LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        ReverseLinkedList(linkedList);
        Console.WriteLine(string.Join(", ", linkedList));
    }
}
