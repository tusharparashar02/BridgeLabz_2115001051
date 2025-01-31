using System;
class NumberGuessingGame
{
    static void Main(string[] args){
        Console.WriteLine("Think of a number between 1 and 100.");
        int low = 1, high = 100, guess;
        string feedback;
        while (true){
            guess = GenerateGuess(low, high);
            Console.WriteLine("Is your number " + guess + "? (Enter 'high', 'low', or 'correct'):");
            feedback = Console.ReadLine().ToLower();
            if (feedback == "correct"){
                Console.WriteLine("Yay! I guessed your number.");
                break;
            }
            else if (feedback == "high"){
                high = guess - 1;
            }
            else if (feedback == "low"){
                low = guess + 1;
            }
            else{
                Console.WriteLine("Invalid input. Please enter 'high', 'low', or 'correct'.");
            }
        }
    }
    static int GenerateGuess(int low, int high){
        Random random = new Random();
        return random.Next(low, high + 1);
    }
}