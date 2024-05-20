using System;

class Program
{
    static void Main(string[] args)
    {
        int n;

        while (true)
        {
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
                break;

            int[,] matrix = new int[n, n];
            CreateMatrix(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();

        }

    }

    public static void CreateMatrix(int[,] matrix)
    {
        int n, i, j, number;

        n = matrix.GetLength(0);


        for (i = 0; i < n; i++)
        {
            number = i + 2;
            for (j = 0; j < n; j++)
            {
                if (i < j)
                    matrix[i, j] = number++;
                else if (i > j)
                    matrix[i, j] = --number;
                else
                    matrix[i, j] = 1;
            }
        }


    }

    public static void PrintMatrix(int[,] matrix)
    {
        int i, j;
        int n = matrix.GetLength(0);

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (j == n - 1)
                    Console.Write(String.Format("{0,3:0}", matrix[i, j]));
                else
                    Console.Write(String.Format("{0,3:0} ", matrix[i, j]));
            }
            Console.WriteLine();
        }
    }
}
