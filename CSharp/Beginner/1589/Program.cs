class Program
{
    static void Main(string[] args)
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        string[] line;
        int r1, r2;
        for(int i = 0; i < n; i++)
        {
            line = Console.ReadLine().Split(' ');
            r1 = Convert.ToInt32(line[0]);
            r2 = Convert.ToInt32(line[1]);
            Console.WriteLine(r1+r2);

        }


    }
}
