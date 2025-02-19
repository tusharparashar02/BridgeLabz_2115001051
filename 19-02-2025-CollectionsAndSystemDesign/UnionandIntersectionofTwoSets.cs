using System;
using System.Collections.Generic;

class UnionandIntersectionofTwoSets
{
    static void UnionAndIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2);

        HashSet<int> intersectionSet = new HashSet<int>(set1);
        intersectionSet.IntersectWith(set2);

        Console.WriteLine("Union: " + string.Join(", ", unionSet));
        Console.WriteLine("Intersection: " + string.Join(", ", intersectionSet));
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        UnionAndIntersection(set1, set2);
    }
}
