class Program
{
    static void Main(string[] args)
    {
        double volume, diameter, area;
        while ( (volume = Convert.ToDouble(Console.ReadLine()) ) != 0 )
        {
            diameter = Convert.ToDouble(Console.ReadLine());
            area = 3.14*0.25*diameter*diameter;
            Console.WriteLine($"ALTURA = {volume/area:0.00}\nAREA = {area:0.00}");

        }
    }
}
