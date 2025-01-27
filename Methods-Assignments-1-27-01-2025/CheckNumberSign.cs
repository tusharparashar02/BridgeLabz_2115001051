using System;

class CheckNumberSign
{
    public static int CheckNumber(int number){
        return number > 0 ? 1 : number < 0 ? -1 : 0;
    }

    static void Main(string[] args){
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Sign of Number: " + CheckNumber(number));
    }
}