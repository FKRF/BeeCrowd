class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int i;
        string line;
        for(i = 0; i < n; i++)
        {
            line = Console.ReadLine();
            if(line[0] == 'T' && line[1] == 'h')
                Console.WriteLine('Y');
            else
                Console.WriteLine('N');
        }
    }
}
