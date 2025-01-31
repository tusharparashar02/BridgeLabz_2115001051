using System;
class PalindromeChecker
{
    static void Main(string[] args){
        Console.Write("Enter a string to check if it's a palindrome: ");
        string input = Console.ReadLine();
        if (IsPalindrome(input))
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
    }
    static bool IsPalindrome(string str){
        str = str.ToLower().Replace(" ", ""); 
        int left = 0, right = str.Length - 1;
        while (left < right){
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}