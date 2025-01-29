using System;
class ComapreTwoString
{
    static void Main(string[] args){
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();
        int result = CompareLexicographically(str1, str2);
        if (result < 0){
            Console.WriteLine( str1 + " comes before " + str2 + " in lexicographical order.");
        }
        else if (result > 0){
            Console.WriteLine( str1 + " comes after " + str2 + " in lexicographical order.");
        }
        else{
            Console.WriteLine(str1 + "and " + str2 + " are the same.");
        }
    }
    static int CompareLexicographically(string str1, string str2)
    {
        int i = 0;
        while (i < str1.Length && i < str2.Length)
        {
            if (str1[i] < str2[i])
                return -1; 
            else if (str1[i] > str2[i])
                return 1;  
            i++;
        }
        if 
            (str1.Length < str2.Length)
            return -1; 
        else if (str1.Length > str2.Length)
            return 1; 
        
        return 0; 
    }
}
