using System;

class SwapTwoNumbers {
    public static void Main(string[] args) {
        Console.WriteLine("Enter two numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        int temp = number1;
        number1 = number2;
        number2 = temp;

        Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
    }
}
