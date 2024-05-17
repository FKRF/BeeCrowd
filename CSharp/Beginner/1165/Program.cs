class Program
{
    static void Main(string[] args)
    {
        int x, i, j, isPrimo;
        int n = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < n; i++)
        {
            x = Convert.ToInt32(Console.ReadLine());
            for (j = 2, isPrimo = 1; j < x; j++)
            {
                if (x % j == 0)
                    isPrimo = 0;
            }
            if (isPrimo == 1)
                Console.WriteLine($"{x} eh primo");
            else
                Console.WriteLine($"{x} nao eh primo");
        }
    }
}
