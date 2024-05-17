using System.Globalization;

namespace _1079;

class Program
{
    static void Main(string[] args)
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        double[] vetMediaPonderada = new double[n];
        var en = new CultureInfo("en-US");

        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            vetMediaPonderada[i] = (double.Parse(values[0], en) * 2 + double.Parse(values[1], en) * 3 + double.Parse(values[2], en) * 5) / 10;
        }

        for (int j = 0; j < n; j++)
            Console.WriteLine(vetMediaPonderada[j].ToString("0.0", en));

    }
}
