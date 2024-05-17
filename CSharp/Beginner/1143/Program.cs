class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i, j;
        for (i = 0, j = 1; i < n; i++, j++)
        {
            Console.WriteLine($"{j} {Math.Pow(j, 2)} {Math.Pow(j, 3)}");
        }

    }
}
