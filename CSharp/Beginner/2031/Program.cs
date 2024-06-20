class Program
{
    static void Main(string[] args)
    {
        int[,] rules = new int[3, 3]{
            {-2, 1, 1}, // attack
            {-1, 0, 1}, // rock
            {-1, -1, 2}, // paper
            
        };
        // -2 both loose, -1 player lost, 0 draw, 1 player win, 2 both win
        int n = Convert.ToInt32(Console.ReadLine());
        string[] line;
        int player1, player2;
        for(int i = 0; i < n; i++)
        {
            player1 = PlayOption(Console.ReadLine());
            player2 = PlayOption(Console.ReadLine());
            RockPaperAttack(rules, player1, player2, i+1);
        }
    }

    static int PlayOption(string play)
    {
        switch(play)
        {
            case "ataque":
                return 0;
            case "pedra":
                return 1;
            case "papel":
                return 2;
            default:
                return -1;
        }
    }


    static void RockPaperAttack(int[,] rules, int p1, int p2, int index)
    {
        int result = rules[p1, p2];
        switch(result)
        {
            case -2:
                Console.WriteLine("Aniquilacao mutua");
                break;
            case -1:
                Console.WriteLine("Jogador 2 venceu");
                break;
            case 0:
                Console.WriteLine("Sem ganhador");
                break;
            case 1:
                Console.WriteLine("Jogador 1 venceu");
                break;
            case 2:
                Console.WriteLine("Ambos venceram");
                break;

        }
    }
}