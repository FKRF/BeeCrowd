
class Program
{
    static void Main(string[] args)
    {
        Int64 n1, n2;
        string[] line = Console.ReadLine().Split(' ');
        n1 = Convert.ToInt64(line[0]);
        n2 = Convert.ToInt64(line[1]);
        Console.WriteLine(n1*n2);
        
    }
}
