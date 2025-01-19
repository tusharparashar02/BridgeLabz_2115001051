using System;

class AddTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());  
        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());  
        
        double sum = num1 + num2;
    
        Console.WriteLine("The sum of the two numbers is: " + sum);
    }
}