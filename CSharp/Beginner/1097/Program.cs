class Program
{
    static void Main(string[] args)
    {
        int j = 7;
        for (int i = 1; i < 10; i += 2)
        {
            for (int k = 0; k < 3; k++)
                Console.WriteLine($"I={i} J={j - k}");
            j += 2;
        }
    }
}
