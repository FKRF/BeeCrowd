class Program
{
    static void Main(string[] args)
    {
        string eof;
        string[] line;
        int v, t;
        while( (line = Console.ReadLine().Split(' ')) != null )
        {
            // line = eof.Split(' ');
            v = Convert.ToInt32(line[0]);
            t = Convert.ToInt32(line[1]);
            Console.WriteLine(v*(2*t));
        }
    }
}
