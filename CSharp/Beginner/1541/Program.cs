class Program
{
    static void Main(string[] args)
    {
        int a, b, c, areaSize;
        double areaDouble;
        string[] line;
        a = -1;
        while (true)
        {
            line = Console.ReadLine().Split(' ');
            a = Convert.ToInt32(line[0]);
            if (a == 0)
                break;
            b = Convert.ToInt32(line[1]);
            c = Convert.ToInt32(line[2]);

            areaDouble = ((a * b) * (100.0 / c));
            areaSize = (int)(Math.Pow(areaDouble, 0.5));
            Console.WriteLine(areaSize);
        }
    }
}
