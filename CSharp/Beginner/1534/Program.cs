class Program
{
    static void Main(string[] args)
    {
        string line;
        int n;
        
        while( (line = Convert.ToString(Console.ReadLine())) != null)
        {
            n = Convert.ToInt32(line);
            PrintMatrix(n);
        }
        
    }

    public static void PrintMatrix(int n)
    {
        int i, j;
        for(i = 0; i < n; i++)
        {
            for(j = 0; j < n; j++)
            {
                
                if ( (i + j) == (n - 1))
                    Console.Write("2");
                else if(i == j)
                    Console.Write("1");
                else
                    Console.Write("3");
            }
            Console.WriteLine();
        }
    }
}
