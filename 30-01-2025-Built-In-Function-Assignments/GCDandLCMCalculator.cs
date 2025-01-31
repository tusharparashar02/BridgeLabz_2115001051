using System;
class GCDandLCMCalculator{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        int gcd = FindGCD(num1, num2);
        int lcm = FindLCM(num1, num2, gcd);
        Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }
    static int FindGCD(int a, int b){
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static int FindLCM(int a, int b, int gcd){
        return (a * b) / gcd;
    }
}