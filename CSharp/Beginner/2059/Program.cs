class Program
{
    static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split();
        int p, j1, j2, r, a, sum;
        p = Convert.ToInt32(line[0]);
        j1 = Convert.ToInt32(line[1]);
        j2 = Convert.ToInt32(line[2]);
        r = Convert.ToInt32(line[3]);
        a = Convert.ToInt32(line[4]);
        sum = j1 + j2;
        if( (r == 1 && a == 0)  || (r == 0 && a == 1))
            Console.WriteLine("Jogador 1 ganha!");
        else if ( (r == 0 && a == 0) && ((sum % 2 == 0 && p == 1) || (sum % 2 == 1 && p == 0)) )
            Console.WriteLine("Jogador 1 ganha!");
        else
            Console.WriteLine("Jogador 2 ganha!");

    }
}
