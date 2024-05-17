class Program
{
    static void Main(string[] args)
    {
        int x, sum, i, j;
        int n = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < n; i++)
        {
            x = Convert.ToInt32(Console.ReadLine());
            for (j = 1, sum = 0; j < x; j++)
            {
                if (x % j == 0)
                    sum += j;
            }
            if (sum == x)
                Console.WriteLine($"{x} eh perfeito");
            else
                Console.WriteLine($"{x} nao eh perfeito");
        }
    }
}
