using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int age = 1, i = 0;
        double sum = 0;
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        while (age > 0)
        {
            age = Convert.ToInt32(Console.ReadLine());
            if (age > 0)
            {
                sum += (double)age;
                i++;
            }
        }
        Console.WriteLine($"{sum / i:0.00}");
    }
}
