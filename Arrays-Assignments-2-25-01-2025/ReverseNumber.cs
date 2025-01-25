using System;
class ReverseNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int temp = number;
        int count = 0;
        while (temp != 0)
        {
            temp /= 10;
            count++;
        }
        int[] digits = new int[count];
        for (int i = 0; i < count; i++){
            digits[i] = number % 10;
            number /= 10;
        }
        Console.WriteLine("Reversed number:");
        for (int i = 0; i < count; i++){
            Console.Write(digits[i]);
        }
    }
}