using System;

class ReplaceWord{
    static void Main(string[] args){
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        Console.WriteLine("Enter the word to replace:");
        string oldWord = Console.ReadLine();
        Console.WriteLine("Enter the new word:");
        string newWord = Console.ReadLine();
        string modifysen = ReplaceWordInSentence(sentence, oldWord, newWord);
        Console.WriteLine("Modified Sentence: " + modifysen);
    }
    static string ReplaceWordInSentence(string sentence, string oldWord, string newWord){
        return sentence.Replace(oldWord, newWord);
    }
}
