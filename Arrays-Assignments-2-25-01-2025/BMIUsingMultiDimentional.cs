using System;

class BMIUsingMultiDimentional
{
    static void Main()
    {
        Console.Write("Enter the number of persons: ");
        int number = int.Parse(Console.ReadLine());
        // Create a 2D array to store height, weight, and BMI for all persons
        double[][] personData = new double[number][];
        string[] weightStatus = new string[number];
        // Initialize 2D array for each person (3 values: height, weight, BMI)
        for (int i = 0; i < number; i++){
            personData[i] = new double[3]; // 0: height, 1: weight, 2: BMI
        }
        for (int i = 0; i < number; i++){
            // Input height and weight, ensuring positive values
            do
            {
                Console.Write("Enter the height (in meters) for person " + (i + 1) + ": ");
                personData[i][0] = double.Parse(Console.ReadLine());
            } while (personData[i][0] <= 0);

            do
            {
                Console.Write("Enter the weight (in kg) for person " + (i + 1) + ": ");
                personData[i][1] = double.Parse(Console.ReadLine());
            } while (personData[i][1] <= 0);

            // Calculate BMI: BMI = weight / (height * height)
            personData[i][2] = personData[i][1] / (personData[i][0] * personData[i][0]);

            // Determine weight status based on BMI
            if (personData[i][2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i][2] >= 18.5 && personData[i][2] < 24.9)
                weightStatus[i] = "Normal weight";
            else if (personData[i][2] >= 25 && personData[i][2] < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        // Display the results for each person
        Console.WriteLine("\nResults:");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ": Height = " + personData[i][0] + " m, Weight = " + personData[i][1] + " kg, BMI = " + personData[i][2] + ", Status = " + weightStatus[i]);
        }
    }
}
