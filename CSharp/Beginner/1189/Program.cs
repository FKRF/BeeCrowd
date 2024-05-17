﻿using System; 

class Program
{
    static void Main(string[] args)
    {
        char operation = Convert.ToChar(Console.ReadLine());
        int i, j;
        double[,] myArray = new double[12, 12];
        double result = 0;
        int count = 0;
        int index1, index2;
        for (i = 0; i < 12; i++)
            for (j = 0; j < 12; j++)
                myArray[i, j] = Convert.ToDouble(Console.ReadLine());    
        
        index1 = 0;
        index2 = 11;
        for(j = 0; j < 5; j++)
        {
            for(i = 0; i < 12; i++)
            {
                if(i > index1 && i < index2)
                {
                    result += myArray[i,j];
                    count++;
                }
            }
            index1++;
            index2--;
        }
        if (operation == 'M')
            Console.WriteLine($"{(result / count):0.0}");
        else if (operation == 'S')
            Console.WriteLine($"{result:0.0}");

    }
}
