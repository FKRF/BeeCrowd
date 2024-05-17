namespace _1113;

class Program
{
    static void Main(string[] args)
    {
        bool status = true;
        int n1, n2;
        while (status)
        {
            string[] line = Console.ReadLine().Split(' ');
            n1 = Convert.ToInt32(line[0]);
            n2 = Convert.ToInt32(line[1]);
            if (n2 > n1)
                Console.WriteLine("Crescente");
            else if (n1 > n2)
                Console.WriteLine("Decrescente");
            else
                status = false;
        }
    }
}
