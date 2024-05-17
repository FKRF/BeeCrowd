class Program
{
    static void Main(string[] args)
    {
        int x, y, sum, i, j, k;
        int n = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split();
            x = Convert.ToInt32(line[0]);
            y = Convert.ToInt32(line[1]);
            sum = 0;
            j = 0;
            k = 0;
            for (; ; )
            {
                if (k == y)
                    break;
                if (ModNumber(x + j, 2) == 1)
                {
                    sum += x + j;
                    k++;
                }
                j++;
            }
            Console.WriteLine(sum);

        }
    }

    public static int ModNumber(int a, int b)
    {
        return ((a % b) + b) % b;
    }
}
