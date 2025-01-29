using System;

class PalindromeCheck
{
    static void Main(string[] args){
        //user input
        Console.WriteLine("Enter the string you want to check:");
        string str = Console.ReadLine();
        if (ISPalindrome(str))
        {
            Console.WriteLine("string is Palindrome");
        }else{
            Console.WriteLine("string is not Palindrome");
        }
    }
    static bool ISPalindrome(string str){
        str = str.ToLower();
        
        int start = 0;
        int end = str.Length -1;
        while(start < end){
            if (str[start] != str[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}