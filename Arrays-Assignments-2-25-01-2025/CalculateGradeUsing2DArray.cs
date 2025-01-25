using System;

class CalculateGradeUsing2DArray
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int number = int.Parse(Console.ReadLine());

        // Create a 2D array to store marks for physics, chemistry, and maths
        double[,] marks = new double[number, 3];
        double[] percentages = new double[number];
        string[] grades = new string[number];

        // Input marks for physics, chemistry, and maths
        for (int i = 0; i < number; i++)
        {
            // Input marks for physics
            do
            {
                Console.Write("Enter the marks for Physics (0-100) for student " + (i + 1) + ": ");
                marks[i, 0] = double.Parse(Console.ReadLine());
            } while (marks[i, 0] < 0 || marks[i, 0] > 100);

            // Input marks for chemistry
            do
            {
                Console.Write("Enter the marks for Chemistry (0-100) for student " + (i + 1) + ": ");
                marks[i, 1] = double.Parse(Console.ReadLine());
            } while (marks[i, 1] < 0 || marks[i, 1] > 100);

            // Input marks for maths
            do
            {
                Console.Write("Enter the marks for Maths (0-100) for student " + (i + 1) + ": ");
                marks[i, 2] = double.Parse(Console.ReadLine());
            } while (marks[i, 2] < 0 || marks[i, 2] > 100);

            // Calculate the percentage
            percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;

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

        // Display the results for each student
        Console.WriteLine("\nResults:");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Student " + (i + 1) + ": Physics = " + marks[i, 0] + ", Chemistry = " + marks[i, 1] + ", Maths = " + marks[i, 2] + ", Percentage = " + percentages[i] + "%, Grade = " + grades[i]);
        }
    }
}
