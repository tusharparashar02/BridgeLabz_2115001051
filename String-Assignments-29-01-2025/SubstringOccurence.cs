using System;

class SubstringOccurence
{
    static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Enter the substring to count: ");
        string substring = Console.ReadLine();
        int count = CountSubstringOcc(input, substring);
        Console.WriteLine("The substring occurs " + count + " times.");
    }
    static int CountSubstringOcc(string str, string substring){
        int count = 0;
        for (int i = 0; i <= str.Length - substring.Length; i++){
            bool match = true;
            for (int j = 0; j < substring.Length; j++){
                if (str[i + j] != substring[j]){
                    match = false;
                    break;
                }
            }
            if (match){
                count++;
            }
        }
        return count;
    }
}
