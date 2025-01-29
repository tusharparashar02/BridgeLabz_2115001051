using System;
class RemoveDuplicate
{
    static void Main(string[] args){
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();
        string result = RemoveDuplicates(input);
        Console.WriteLine("String after removing duplicates: " + result);
    }

    static string RemoveDuplicates(string input)
    {
        string result = "";
        for (int i = 0; i < input.Length; i++){
            bool found = false;
            for (int j = 0; j < result.Length; j++){
                if (input[i] == result[j]){
                    found = true;
                    break;
                }
            }
            if (!found){
                result += input[i];
            }
        }
        return result;
    }
}