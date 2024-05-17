class Program
{
    static void Main(string[] args)
    {
        int x, y;
        bool loop = true;

        while (loop)
        {
            string[] line = Console.ReadLine().Split(' ');
            x = Convert.ToInt32(line[0]);
            y = Convert.ToInt32(line[1]);
            if (x == 0 || y == 0)
                loop = false;
            else
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("primeiro");
                if (x < 0 && y > 0)
                    Console.WriteLine("segundo");
                if (x < 0 && y < 0)
                    Console.WriteLine("terceiro");
                if (x > 0 && y < 0)
                    Console.WriteLine("quarto");
            }
        }
    }
}
