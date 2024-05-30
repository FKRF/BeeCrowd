class Program
{
    static void Main(string[] args)
    {
        int n, i, n1, n2;

        n = Convert.ToInt32(Console.ReadLine());
        string[] line;
        for(i = 0; i < n; i++)
        {
            line = Console.ReadLine().Split(' ');
            n1 = Convert.ToInt32(line[0]);
            n2 = Convert.ToInt32(line[1]);
            Console.WriteLine(MaxDivisor(n1, n2));
        }
    }

    static int MaxDivisor(int a, int b)
    {
        return (b == 0) ? a : MaxDivisor(b, a % b);
    }

}
