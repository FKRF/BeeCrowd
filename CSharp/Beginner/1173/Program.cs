    class Program
    {
        static void Main(string[] args)
        {
            int[] x10 = new int[10];
            int n = Convert.ToInt32(Console.ReadLine());
            x10[0] = n;
            for (int i = 1; i < 10; i++)
                x10[i] = 2 * x10[i - 1];

            for (int j = 0; j < 10; j++)
                Console.WriteLine($"N[{j}] = {x10[j]}");
        }
    }
