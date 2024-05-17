using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        decimal x = Convert.ToDecimal(Console.ReadLine());
        int i;
        x = Math.Round(x, 4);
        Console.WriteLine($"N[0] = {x:0.0000}");
        for (i = 1; i < 100; i++)
        {
            x /= 2m;
            Console.WriteLine($"N[{i}] = {Math.Round(x, 4):0.0000}");
        }
    }
}
