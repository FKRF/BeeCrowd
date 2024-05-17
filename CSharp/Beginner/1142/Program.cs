class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i, j;
        for (i = 0, j = 1; i < n; j += 4)
        {
            Console.WriteLine($"{j} {j + 1} {j + 2} PUM");
            i++;
        }

    }
}
