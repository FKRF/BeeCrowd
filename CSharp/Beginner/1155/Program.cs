class Program
{
    static void Main(string[] args)
    {
        double sum = 0;
        for (double i = 1; i <= 100; i++)
            sum += 1 / i;
        Console.WriteLine($"{sum:0.00}");
    }
}
