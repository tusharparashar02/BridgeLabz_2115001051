using System;
class ReverseString
{
    static void Main(string[] args){
        Console.WriteLine("Enetr the String :");
        string input = Console.ReadLine();
        string reverse = Reversed(input);
        Console.WriteLine("Reversed String: "+ reverse);
    }
    static string Reversed(string str){
        char[] charArray = str.ToCharArray();
        int start = 0;
        int end = charArray.Length - 1;
        while(start < end){
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            start++;
            end--;
        }
        return new string(charArray);
    }
}