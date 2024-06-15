using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int numberDecimal= Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[12]{1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900};
        Console.WriteLine(DecimalToRoman(numbers, numberDecimal));
    }

    static string DigitDecimalToRoman(int n)
    {
        switch(n)
        {
            case 1:
                return "I";
            case 4:
                return "IV";
            case 5:
                return "V";
            case 9:
                return "IX";
            case 10:
                return "X";
            case 40:
                return "XL";
            case 50:
                return "L";
            case 90:
                return "XC";
            case 100:
                return "C";
            case 400:
                return "CD";
            case 500:
                return "D";
            case 900:
                return "CM";
            default:
                return "\0";
        }
    }

    static StringBuilder DecimalToRoman(int[] numbers, int a)
    {
        int i, j, r, b;
        var numberRoman = new StringBuilder();
        for(i = 11; i >= 0; i--)
        {
            b = 0; 
            r = a % numbers[i];
            b = a / numbers[i];
            a = a % numbers[i];
            
            if (b != 0 ) 
                for(j = 0; j < b; j++)
                    numberRoman.Append(DigitDecimalToRoman(numbers[i])); 
        }
        return numberRoman;
    }
}
