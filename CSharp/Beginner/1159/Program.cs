class Program
{
    static void Main(string[] args)
    {
        int x = -1;
        int k, sum;
        while (x != 0)
        {
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
                break;
            k = 0;
            sum = 0;
            for (int i = 0; ; i++)
            {
                if (k == 5)
                    break;
                if ((x + i) % 2 == 0)
                {
                    sum += x + i;
                    k++;
                }
            }
            Console.WriteLine(sum);
        }

    }

    public static int NumberMod(int a, int b)
    {
        return ((a % b) + b) % b;
    }
}
