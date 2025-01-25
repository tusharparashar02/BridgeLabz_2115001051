using System;

class CalculateGradeOfPCM
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int number = int.Parse(Console.ReadLine());

        // Arrays to store marks, percentages, and grades of the students
        double[] physicsMarks = new double[number];
        double[] chemistryMarks = new double[number];
        double[] mathsMarks = new double[number];
        double[] percentages = new double[number];
        string[] grades = new string[number];

        for (int i = 0; i < number; i++)
        {
            // Input marks for physics, chemistry, and maths
            do
            {
                Console.Write("Enter the marks for Physics (0-100) for student " + (i + 1) + ": ");
                physicsMarks[i] = double.Parse(Console.ReadLine());
            } while (physicsMarks[i] < 0 || physicsMarks[i] > 100);

            do
            {
                Console.Write("Enter the marks for Chemistry (0-100) for student " + (i + 1) + ": ");
                chemistryMarks[i] = double.Parse(Console.ReadLine());
            } while (chemistryMarks[i] < 0 || chemistryMarks[i] > 100);

            do
            {
                Console.Write("Enter the marks for Maths (0-100) for student " + (i + 1) + ": ");
                mathsMarks[i] = double.Parse(Console.ReadLine());
            } while (mathsMarks[i] < 0 || mathsMarks[i] > 100);

            // Calculate the percentage
            percentages[i] = (physicsMarks[i] + chemistryMarks[i] + mathsMarks[i]) / 3;

            // Determine the grade based on the percentage
            if (percentages[i] >= 80)
                grades[i] = "A (Level 4, above agency-normalized standards)";
            else if (percentages[i] >= 70)
                grades[i] = "B (Level 3, at agency-normalized standards)";
            else if (percentages[i] >= 60)
                grades[i] = "C (Level 2, below, but approaching agency-normalized standards)";
            else if (percentages[i] >= 50)
                grades[i] = "D (Level 1, well below agency-normalized standards)";
            else if (percentages[i] >= 40)
                grades[i] = "E (Level 1-, too below agency-normalized standards)";
            else
                grades[i] = "R (Remedial standards)";
        }

        // Display the results
        Console.WriteLine("\nResults:");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Student " + (i + 1) + ": Physics = " + physicsMarks[i] + ", Chemistry = " + chemistryMarks[i] + ", Maths = " + mathsMarks[i] + ", Percentage = " + percentages[i] + "%, Grade = " + grades[i]);
        }
    }
}
