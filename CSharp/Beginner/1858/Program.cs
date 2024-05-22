class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] line = Console.ReadLine().Split(' ');
        int minor = Convert.ToInt32(line[0]);
        int index = 1, aux;
        for(int i = 1; i < n; i++)
        {
            aux = Convert.ToInt32(line[i]);
            if( aux < minor)
            {
                minor = aux;
                index = i + 1;
            }
        }
        Console.WriteLine(index);
    }
}
