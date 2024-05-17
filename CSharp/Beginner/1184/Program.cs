class Program
{
    static void Main(string[] args)
    {
        char operation = Convert.ToChar(Console.ReadLine());
        int i, j;
        double[,] myArray = new double[12, 12];
        double result = 0;
        int count = 0;
        for (i = 0; i < 12; i++)
        {
            for (j = 0; j < 12; j++)
            {
                myArray[i, j] = Convert.ToDouble(Console.ReadLine());
                if (i > j)
                {
                    result += myArray[i, j];
                    count++;
                }
            }
        }
        if (operation == 'M')
            Console.WriteLine($"{(result / count):0.0}");
        else if (operation == 'S')
            Console.WriteLine($"{result:0.0}");

    }
}
