class Program
{
    static void Main(string[] args)
    {
        int x, y;
        string[] line = Console.ReadLine().Split(' ');
        x = Convert.ToInt32(line[0]);
        y = Convert.ToInt32(line[1]);
        Console.Write(1);
        for (int i = 2; i <= x; i++)
            Console.Write(" " + i);

        Console.WriteLine();
        for (int j = x + 1; j <= y; j++)
        {
            if (j % x == 0)
                Console.WriteLine(j);
            else
                Console.Write(j + " ");
        }

    }


}
