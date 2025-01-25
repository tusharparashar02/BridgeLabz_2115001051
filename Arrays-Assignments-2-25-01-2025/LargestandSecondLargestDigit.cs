using System;
class LargestandSecondLargestDigit
{
    static void Main(string[] args){
        Console.WriteLine("Enter a number:");
        int userNumber = int.Parse(Console.ReadLine());
        int[] digitsArray = new int[10];
        int arrayIndex = 0;
        while (userNumber > 0){
            digitsArray[arrayIndex] = userNumber % 10;
            userNumber = userNumber / 10;
            arrayIndex++;
        }
        int largestDigit = -1;
        int secondLargestDigit = -1;
        for (int i = 0; i < arrayIndex; i++){
            if (digitsArray[i] > largestDigit)
            {
                secondLargestDigit = largestDigit;
                largestDigit = digitsArray[i];
            }
            else if (digitsArray[i] > secondLargestDigit && digitsArray[i] != largestDigit)
            {
                secondLargestDigit = digitsArray[i];
            }
        }
        Console.WriteLine("Largest digit is: " + largestDigit);
        Console.WriteLine("Second largest digit is: " + secondLargestDigit);
    }
}