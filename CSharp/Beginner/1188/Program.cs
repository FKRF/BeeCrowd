class Program
{
    static void Main(string[] args)
    {
        char operation = Convert.ToChar(Console.ReadLine());
        int i, j;
        double[,] myArray = new double[12, 12];
        double result = 0;
        int count = 0;
        int index1 = -1, index2 = -1;
        int flag = 0;
        for (i = 0; i < 12; i++)
        {
            if (i == 6 && flag == 0)
            {
                index1 = 5;
                index2 = 6;
            }
            for (j = 0; j < 12; j++)
            {
                myArray[i, j] = Convert.ToDouble(Console.ReadLine());
                if (j > index1 && j < index2)
                {
                    result += myArray[i, j];
                    count++;
                }
            }
            if (flag == 1)
            {
                index1--;
                index2++;
            }
        }
        if (operation == 'M')
            Console.WriteLine($"{(result / count):0.0}");
        else if (operation == 'S')
            Console.WriteLine($"{result:0.0}");

    }
}
