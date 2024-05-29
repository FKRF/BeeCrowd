class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string numberString;
        int numberSize;
        int numberLeds, aux;
        for(int j = 0; j < n; j++)
        {
            numberString = Console.ReadLine();
            numberSize = numberString.Count();
            numberLeds = 0;
            for(int i = 0; i < numberSize; i++)
            {
                aux = LedsByDigit((Convert.ToInt32(numberString[i])) - 48);
                numberLeds += aux;
            }
            Console.WriteLine($"{numberLeds} leds");
        }
        
        

        
    }

    static int LedsByDigit(int digit)
    {
        switch(digit)
        {
            case 0:
                return 6;
            case 1:
                return 2;
            case 2:
                return 5;
            case 3:
                return 5;
            case 4:
                return 4;
            case 5:
                return 5;
            case 6:
                return 6;
            case 7:
                return 3;
            case 8:
                return 7;
            case 9:
                return 6;
            default:
                return -1;
        }
    }
}
