using System;

class LongestWordinSentence
{
    static void Main(string[] args){
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        string longword = FindLongestWord(input);
        Console.WriteLine("Longest word in the sentence: " + longword);
    }

    static string FindLongestWord(string sentence){
        string longword = "";
        string word = "";
        for (int i = 0; i < sentence.Length; i++){
            if (sentence[i] != ' '){
                word += sentence[i];
            }
            else{
                if (word.Length > longword.Length){
                    longword = word;
                }
                word = "";
            }
        }
        if (word.Length > longword.Length){
            longword = word;
        }
        return longword;
    }
}