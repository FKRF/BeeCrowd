class Program
{
    static void Main(string[] args)
    {
        string time;
        string[] line;
        int hours, minutes, delayMax = -1;
        while( (time = Console.ReadLine()) != null)
        {
            line = time.Split(':');
            hours = Convert.ToInt32(line[0]);
            minutes = Convert.ToInt32(line[1]);
            hours += 1;
            if( hours < 8 || (hours == 8 && minutes == 0) )
                delayMax = 0;
            else if (hours >= 8)
                delayMax = (hours - 8)*60 + minutes;
            Console.WriteLine($"Atraso maximo: {delayMax}");

        }
    }
}
