using System;

class CheckVotingEligibility
{
    static void Main(string[] args)
    {
        // Define an array to store the ages of 10 students
        int[] ages = new int[10];
        Console.WriteLine("Enter the ages of 10 students:");
        // user input for all 10 ages
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());
        }
        // Check the voting eligibility for each student
        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0){
                Console.WriteLine("The student with age " + ages[i] + ": Invalid age");
            }
            else if (ages[i] >= 18){
                Console.WriteLine("The student with the age " + ages[i] + " can vote.");
            }
            else{
                Console.WriteLine("The student with the age " + ages[i] + " cannot vote.");
            }
        }
    }
}
