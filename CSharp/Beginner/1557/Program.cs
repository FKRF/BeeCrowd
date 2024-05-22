﻿class Program
{
    static void Main(string[] args)
    {
        string line;
        int n;
        
        while( (line = Convert.ToString(Console.ReadLine())) != null)
        {
            n = Convert.ToInt32(line);
            if(n == 0)
                break;
            int[,] myMatrix = new int[n, n];
            CreateMatrix(myMatrix);
            PrintMatrix(myMatrix);
            Console.WriteLine();
            
        }

        
    }

    public static void CreateMatrix(int[,] matrix)
    {
        int i, j, k, n;
        n = matrix.GetLength(0);
        for(i = 0; i < n; i++)
        {
            k = IntPow(2, i);
            for(j = 0; j < n; j++)
            {
                matrix[i, j] = k;
                k *= 2;
            }            
            
        }
    }

    public static void PrintMatrix(int[,] matrix)
    {   
        int n = matrix.GetLength(0);
        string greaterNumber = Convert.ToString(matrix[n - 1, n - 1]);
        int sizeNumber = greaterNumber.Length;

        string formatNumber = "{0," + Convert.ToString(sizeNumber) + ":0}";
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(j == n -1)
                    Console.Write(matrix[i, j].ToString().PadLeft(sizeNumber));
                else
                    Console.Write(matrix[i, j].ToString().PadLeft(sizeNumber) + " ");
            }
            Console.WriteLine();
        }
        
    }
    public static int IntPow(int x, int y)
    {
        int num = x;
        if(y == 0)
            return 1;
        if(y == 1)
            return num;
        for(int i = 1; i < y; i++)
            {
                num *= x;
            }
        return num;
    }
}