class Program
{
    static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(' ');
        int a, b, c;
        a = Convert.ToInt32(line[0]);
        b = Convert.ToInt32(line[1]);
        c = (a + b + Math.Abs(a-b))/2;
        Console.WriteLine(c);
    }
}
