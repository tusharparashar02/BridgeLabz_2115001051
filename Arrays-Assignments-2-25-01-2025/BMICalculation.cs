using System;

class BMICalculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of persons: ");
        int number = int.Parse(Console.ReadLine());

        // Arrays to store height, weight, BMI, and weight status
        double[] heights = new double[number];
        double[] weights = new double[number];
        double[] bmi = new double[number];
        string[] status = new string[number];

        for (int i = 0; i < number; i++)
        {
            // Get height and weight for each person
            Console.Write("Enter the height (in meters) for person " + (i + 1) + ": ");
            heights[i] = double.Parse(Console.ReadLine());

            Console.Write("Enter the weight (in kg) for person " + (i + 1) + ": ");
            weights[i] = double.Parse(Console.ReadLine());

            // Calculate BMI (BMI = weight / (height * height))
            bmi[i] = weights[i] / (heights[i] * heights[i]);

            // Determine weight status based on BMI
            if (bmi[i] < 18.5)
                status[i] = "Underweight";
            else if (bmi[i] >= 18.5 && bmi[i] < 24.9)
                status[i] = "Normal weight";
            else if (bmi[i] >= 25 && bmi[i] < 29.9)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }
        // Display the results
        Console.WriteLine("\nResults:");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ": Height = " + heights[i] + " m, Weight = " + weights[i] + " kg, BMI = " + bmi[i] + ", Status = " + status[i]);
        }
    }
}
