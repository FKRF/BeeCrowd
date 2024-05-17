class Program
{
    static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int z = x;
        while (z <= x)
            z = Convert.ToInt32(Console.ReadLine());
        int sum = x, i;
        for (i = x + 1; sum < z; i++)
            sum += i;
        Console.WriteLine(i - x);
    }
}
