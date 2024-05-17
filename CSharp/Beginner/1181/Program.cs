using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        int line = Convert.ToInt32(Console.ReadLine());
        string operation = Console.ReadLine();
        int i, j;
        double result = 0;
        double[,] myArray = new double[12, 12];
        for (i = 0; i < 12; i++)
        {
            for (j = 0; j < 12; j++)
            {
                myArray[i, j] = Convert.ToDouble(Console.ReadLine());
                if (i == line)
                    result += myArray[i, j];

            }
        }
        if (operation == "M")
            result /= 12;

        Console.WriteLine($"{result:0.0}");
    }
}
