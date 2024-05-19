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
        int n, i, j, k, beginLine, endLine, beginColumn, endColumn;

        n = matrix.GetLength(0);
        beginLine = 0;
        endLine = n;
        beginColumn = 0;
        endColumn = n;
        for (k = 1; k <= n; k++)
        {
            for (i = beginLine; i < endLine; i++)
            {
                for (j = beginColumn; j < endColumn; j++)
                {
                    matrix[i, j] = k;
                }
            }
            // beginLine++;
            // beginColumn++;
            // endLine--;
            // endColumn--;
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
