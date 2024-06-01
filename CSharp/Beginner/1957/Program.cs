using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int numberDecimal = Convert.ToInt32(Console.ReadLine());
        int a, r;
        if(numberDecimal < 16)
            Console.WriteLine(DecimalToHexaDigit(numberDecimal));
        else
        {
            StringBuilder numberHexa = new StringBuilder();
            a = numberDecimal;
            r = 16;
            while(a > 15)
            {
                r = a % 16;
                a = a / 16;
                numberHexa.Append(DecimalToHexaDigit(r));
            }
            numberHexa.Append(DecimalToHexaDigit(a));
            Console.WriteLine(new string(numberHexa.ToString().Reverse().ToArray()));

        }
        

    }

    static string DecimalToHexaDigit(int digit)
    {
        switch(digit)
        {
            case 0:
                return "0";
            case 1:
                return "1";
            case 2:
                return "2";
            case 3:
                return "3";
            case 4:
                return "4";
            case 5:
                return "5";
            case 6:
                return "6";
            case 7:
                return "7";
            case 8:
                return "8";
            case 9:
                return "9";
            case 10:
                return "A";
            case 11:
                return "B";
            case 12:
                return "C";
            case 13:
                return "D";
            case 14:
                return "E";
            case 15:
                return "F";
            default:
                return "-1";
        }
    }
}
