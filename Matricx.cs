using System;

class MatrixOperations
{
   
    public static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return result;
    }

 
    public static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }

        return result;
    }

   
    public static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int aRows = matrixA.GetLength(0);
        int aCols = matrixA.GetLength(1);
        int bRows = matrixB.GetLength(0);
        int bCols = matrixB.GetLength(1);

        if (aCols != bRows)
            throw new InvalidOperationException("Matrices cannot be multiplied.");

        int[,] result = new int[aRows, bCols];

        for (int i = 0; i < aRows; i++)
        {
            for (int j = 0; j < bCols; j++)
            {
                for (int k = 0; k < aCols; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }

    
    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

   
    static void Main()
    {
        int[,] matrixA = { { 1, 2 }, { 3, 4 } };
        int[,] matrixB = { { 5, 6 }, { 7, 8 } };

        Console.WriteLine("Matrix A:");
        PrintMatrix(matrixA);

        Console.WriteLine("Matrix B:");
        PrintMatrix(matrixB);

        int[,] sum = AddMatrices(matrixA, matrixB);
        Console.WriteLine("Sum of A and B:");
        PrintMatrix(sum);

        int[,] difference = SubtractMatrices(matrixA, matrixB);
        Console.WriteLine("Difference of A and B:");
        PrintMatrix(difference);

        int[,] product = MultiplyMatrices(matrixA, matrixB);
        Console.WriteLine("Product of A and B:");
        PrintMatrix(product);
    }
}