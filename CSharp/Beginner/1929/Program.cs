class Program
{
    static void Main(string[] args)
    {
        int a, b, c, d, result;
        string[] line = Console.ReadLine().Split(' ');
        a = Convert.ToInt32(line[0]);
        b = Convert.ToInt32(line[1]);
        c = Convert.ToInt32(line[2]);
        d = Convert.ToInt32(line[3]);
        result = IsTriangle(a, b, c) + IsTriangle(b, c, d) + IsTriangle(c, d, a) + IsTriangle(d, a, b);
        if(result != 0)
            Console.WriteLine('S');
        else
            Console.WriteLine('N');
    }

    static int IsTriangle(int a, int b, int c)
    {
        if(a + b > c && a + c > b && b + c > a)
            return 1;
        else
            return 0;
    }
}
