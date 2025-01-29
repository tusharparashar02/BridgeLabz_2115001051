using System;

class MostFrequentCharacter
{
    static void Main(string[] args){
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        char mostFrequentChar = FindMostFrequentCharacter(input);
        Console.WriteLine("Most Frequent Character: '" + mostFrequentChar + "'");
    }
    static char FindMostFrequentCharacter(string input)
    {
        int maxCount = 0;
        char mostFrequentChar = ' ';
        for (int i = 0; i < input.Length; i++){
            int count = 0;
            for (int j = 0; j < input.Length; j++){
                if (input[i] == input[j]){
                    count++;
                }
            }
            if (count > maxCount){
                maxCount = count;
                mostFrequentChar = input[i];
            }
        }
        return mostFrequentChar;
    }
}
