using System;

class EuclideanDistanceAndLineEquation
{
    public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double[] result = new double[2];
        
        // Calculate the slope (m)
        double m = (y2 - y1) / (x2 - x1);
        
        // Calculate the y-intercept (b)
        double b = y1 - (m * x1);

        result[0] = m; 
        result[1] = b; 

        return result;
    }

    static void Main(string[] args)
    {
        // Take inputs for two points (x1, y1) and (x2, y2)
        Console.WriteLine("Enter the coordinates of the first point (x1, y1): ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the coordinates of the second point (x2, y2): ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());
        // Calculate and display the Euclidean distance
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine("The Euclidean distance between the two points is: " + distance);
        // Find and display the equation of the line
        double[] equation = FindLineEquation(x1, y1, x2, y2);
        Console.WriteLine("The equation of the line is: y = " + equation[0] + "x + " + equation[1]);
    }
}
