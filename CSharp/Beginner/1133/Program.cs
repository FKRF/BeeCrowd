﻿class Program
{
    static void Main(string[] args)
    {
        int n1, n2, aux;
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        if (n1 > n2)
        {
            aux = n1;
            n1 = n2;
            n2 = aux;
        }
        for (int i = n1 + 1; i < n2; i++)
            if (i % 5 == 2 || i % 5 == 3)
                Console.WriteLine(i);

    }

}
