using System;
class SumOfNNaturalNO
{
    public static int Sum(int n){
        int sum = 0;
        for(int i=0; i<=n; i++){
            sum+=i;
        }
        return sum;
    }
    static void Main(string[] args){
        Console.WriteLine("Enter the number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of N natural no is: "+ Sum(num));
    }
}