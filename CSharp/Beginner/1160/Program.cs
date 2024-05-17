using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        int pA, pB, j;
        double gA, gB;
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            pA = Convert.ToInt32(line[0]);
            pB = Convert.ToInt32(line[1]);
            gA = Convert.ToDouble(line[2]) / 100;
            gB = Convert.ToDouble(line[3]) / 100;

            for (j = 0; j <= 100; j++)
            {
                if (pA > pB)
                    break;
                pA = (int)(pA * (1 + (gA)));
                pB = (int)(pB * (1 + (gB)));
            }
            if (j <= 100)
                Console.WriteLine($"{j} anos.");
            else
                Console.WriteLine("Mais de 1 seculo.");
        }
    }
}
