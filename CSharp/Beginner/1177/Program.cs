class Program
{
    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());
        int i, j;
        for (i = 0, j = 0; i < 1000; i++, j++)
        {
            if (j == n)
                j = 0;
            Console.WriteLine($"N[{i}] = {j}");
        }
    }
}
