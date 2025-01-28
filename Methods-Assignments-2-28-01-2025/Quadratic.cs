using System;

class Quadratic
{
    // Method to find the roots of the quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = (b * b) - (4 * a * c);
        if (delta > 0){
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0){
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else{
            // Return an empty array if no real roots exist
            return new double[] { };
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter the value of a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of c:");
        double c = Convert.ToDouble(Console.ReadLine());

        // Find the roots
        double[] roots = FindRoots(a, b, c);

        // Display the roots
        if (roots.Length == 2){
            Console.WriteLine("The roots of the equation are: " + roots[0] + " and " + roots[1]);
        }
        else if (roots.Length == 1){
            Console.WriteLine("The root of the equation is: " + roots[0]);
        }
        else{
            Console.WriteLine("The equation has no real roots.");
        }
    }
}
