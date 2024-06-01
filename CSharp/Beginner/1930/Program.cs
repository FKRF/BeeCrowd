class Program
{
    static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(' ');
        int t1, t2, t3, t4, qt;
        t1 = Convert.ToInt32(line[0]);
        t2 = Convert.ToInt32(line[1]);
        t3 = Convert.ToInt32(line[2]);
        t4 = Convert.ToInt32(line[3]);
        qt = t1 + t2 + t3 + t4 - 3;
        Console.WriteLine(qt);
    }
}
