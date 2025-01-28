using System;
public class BMICalculation
{
    public static double CalculateBMI(double weight, double heightInCm){
        double heightInMeters = heightInCm / 100;
        return weight / (heightInMeters * heightInMeters);
    }
    public static string DetermineBMIStatus(double bmi){
        if (bmi < 18.5) return "Underweight";
        if (bmi < 24.9) return "Normal weight";
        if (bmi < 29.9) return "Overweight";
        return "Obese";
    }
    public static void Main()
    {
        double[,] data = new double[10, 3];

        for (int i = 0; i < 10; i++){
            Console.WriteLine("Enter the weight (in kg) of person " + (i + 1) + ": ");
            data[i, 0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height (in cm) of person " + (i + 1) + ": ");
            data[i, 1] = double.Parse(Console.ReadLine());

            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
        }

        for (int i = 0; i < 10; i++){
            Console.WriteLine("Person " + (i + 1) + ":");
            Console.WriteLine("Weight: " + data[i, 0] + " kg, Height: " + data[i, 1] + " cm");
            Console.WriteLine("BMI: " + data[i, 2] + ", Status: " + DetermineBMIStatus(data[i, 2]));
        }
    }
}
