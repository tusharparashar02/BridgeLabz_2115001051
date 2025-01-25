using System;

class Copy2DArrayinto1DArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows:");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns:");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int[] oneDArray = new int[rows * cols];
        int index = 0;
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++)
            {
                oneDArray[index] = matrix[i, j];
                index++;
            }
        }
        Console.WriteLine("The 1D array is:");
        for (int i = 0; i < oneDArray.Length; i++){
            Console.WriteLine(oneDArray[i]);
        }
    }
}
