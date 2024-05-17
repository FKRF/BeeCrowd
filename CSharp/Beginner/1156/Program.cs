class Program
{
    static void Main(string[] args)
    {
        double i, j, sum = 0;
        for (i = 1, j = 1; j <= 39; i *= 2, j += 2)
            sum += j / i;
        Console.WriteLine($"{sum:0.00}");
    }
}
