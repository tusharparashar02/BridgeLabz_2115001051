using System;
class SimpleInterest
{
    static double SI(double principal, double rate, double time){
        return (principal*rate*time)/100;
    }
    static void Main(string[] args){
        Console.WriteLine("Enter the Principle Amount");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Rate Amount");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the time");
        double time = Convert.ToDouble(Console.ReadLine());

        //Function Call
        double simpleInt = SI(principal, rate, time);
        //Print
        Console.WriteLine("The Simple Interest is " +simpleInt + "for Principal "+ principal+", Rate of Interest " + rate + "and Time " + time);
    }
}