class Program
{
    static void Main(string[] args)
    {
        int[] x10 = new int[10];
        for (int i = 0; i < 10; i++)
        {
            x10[i] = Convert.ToInt32(Console.ReadLine());
            if (x10[i] <= 0)
                x10[i] = 1;
        }
        for (int j = 0; j < 10; j++)
            Console.WriteLine($"X[{j}] = {x10[j]}");
    }
}
