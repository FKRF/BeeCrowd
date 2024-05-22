class Program
{
    static void Main(string[] args)
    {
        string line;
        int n;
        while( (line = Console.ReadLine())!= null)
        {
            n = Convert.ToInt32(line);
            if (n == 0)
                Console.WriteLine("vai ter copa!");
            else
                Console.WriteLine("vai ter duas!");

        }
    }
}
