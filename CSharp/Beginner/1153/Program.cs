class Program
{
    static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fatorial(x));
    }

    public static int Fatorial(int n)
    {
        if (n == 1)
            return 1;
        return n * Fatorial(n - 1);
    }
}
