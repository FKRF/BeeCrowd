using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double x, y;
        var cultureInfo = new CultureInfo("en-US");
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            x = (Convert.ToDouble(line[0]));
            y = Convert.ToDouble(line[1]);
            if (y == 0)
                Console.WriteLine("divisao impossivel");
            else
                Console.WriteLine($"{x / y:0.0}");
        }
    }
}
