class Program
{
    static void Main(string[] args)
    {
        int[,] rules = new int[5, 5]{
            {0, 1, -1, 1, -1}, // scissors
            {-1, 0, 1, -1, 1}, // paper
            {1, -1, 0, 1, -1}, // rock
            {-1, 1, -1, 0, 1}, // lizard
            {1, -1, 1, -1, 0} // Spock
        };
        int n = Convert.ToInt32(Console.ReadLine());
        string[] line;
        int sheldon, raj;
        for(int i = 0; i < n; i++)
        {
            line = Console.ReadLine().Split(' ');
            sheldon = PlayOption(line[0]);
            raj = PlayOption(line[1]);
            LizardSpock(rules, sheldon, raj, i+1);
        }
    }

    static int PlayOption(string play)
    {
        switch(play)
        {
            case "tesoura":
                return 0;
            case "papel":
                return 1;
            case "pedra":
                return 2;
            case "lagarto":
                return 3;
            case "Spock":
                return 4;
            default:
                return -1;
        }
    }


    static void LizardSpock(int[,] rules, int p1, int p2, int index)
    {
        int result = rules[p1, p2];
        switch(result)
        {
            case 1:
                Console.WriteLine($"Caso #{index}: Bazinga!");
                break;
            case -1:
                Console.WriteLine($"Caso #{index}: Raj trapaceou!");
                break;
            case 0:
                Console.WriteLine($"Caso #{index}: De novo!");
                break;
        }
    }
}
