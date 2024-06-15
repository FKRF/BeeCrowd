using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture =  new CultureInfo("en-US");
        string[] line = Console.ReadLine().Split(' ');
        double valueOld, valueNew, perc;
        valueOld = Convert.ToDouble(line[0]);
        valueNew = Convert.ToDouble(line[1]);
        perc = ((valueNew/valueOld)*100) - 100;
        Console.WriteLine($"{perc:0.00}%"); 
    }
}
