using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        var cultureInfo = new CultureInfo("en-US");
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        double number = Convert.ToDouble(Console.ReadLine());
        string numberString;
        if(number == 0)
        {
            numberString = number.ToString();
            if(numberString[0] != '-')
                numberString = "+0.0000E+00";
            else
                numberString = "-0.0000E+00";
        }
        else
        {
            numberString = number.ToString("0.0000E+00");
            if(numberString[0] != '-') 
                numberString = "+" + numberString;
        }
        
        Console.WriteLine(numberString);
    }
}
