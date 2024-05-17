class Program
{
    static void Main(string[] args)
    {
        int a, n, sum;
        bool loop = true;

        sum = 0;
        n = 0;
        string[] line = Console.ReadLine().Split(' ');
        a = Convert.ToInt32(line[0]);
        for (int i = 1; loop; i++)
        {
            n = Convert.ToInt32(line[i]);
            if (n > 0)
                loop = false;
        }

        for (int i = 0; i < n; i++)
            sum += a + i;

        Console.WriteLine(sum);
    }
}
