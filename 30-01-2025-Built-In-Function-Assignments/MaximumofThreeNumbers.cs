using System;
class MaximumofThreeNumbers
{
    static void Main(string[] args){
        int num1 = GetNumber("Enter the first number: ");
        int num2 = GetNumber("Enter the second number: ");
        int num3 = GetNumber("Enter the third number: ");

        int maxNumber = GetMaximum(num1, num2, num3);
        Console.WriteLine("The maximum number is: " + maxNumber);
    }
    static int GetNumber(string message){
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    static int GetMaximum(int a, int b, int c){
        return Math.Max(a, Math.Max(b, c));
    }
}