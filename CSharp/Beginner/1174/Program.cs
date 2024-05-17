class Program
{
    static void Main(string[] args)
    {
        double[] aArray = new double[100];

        for (int i = 0; i < 100; i++)
            aArray[i] = Convert.ToDouble(Console.ReadLine());

        for (int j = 0; j < 100; j++)
            if (aArray[j] <= 10)
                Console.WriteLine($"A[{j}] = {aArray[j]:0.0}");
    }
}
