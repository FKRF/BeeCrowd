using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double n, average;
        int i;
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        bool loop = true;
        int newAverage;
        while (loop)
        {
            for (i = 0, average = 0; i < 2;)
            {
                n = Convert.ToDouble(Console.ReadLine());
                if (n >= 0 && n <= 10)
                {
                    average += n;
                    i++;
                }
                else
                    Console.WriteLine("nota invalida");
            }
            average /= 2;
            Console.WriteLine($"media = {average:0.00}");

            newAverage = -1;
            while (newAverage != 1 && newAverage != 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                newAverage = Convert.ToInt32(Console.ReadLine());
            }
            if (newAverage == 2)
                loop = false;


        }

    }
}
