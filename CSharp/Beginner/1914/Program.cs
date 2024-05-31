class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] line1, line2;
        string player1, play1, player2, play2, result;
        int number1, number2, sum;
        for(int i = 0; i < n; i++)
        {
            line1 = Console.ReadLine().Split(' ');
            player1 = line1[0];
            play1 = line1[1];
            player2 = line1[2];
            play2 = line1[3];
            line2 = Console.ReadLine().Split(' ');    
            number1 = Convert.ToInt32(line2[0]);
            number2 = Convert.ToInt32(line2[1]);
            sum = number1 + number2;
            if (sum % 2 == 0)
                result = "PAR";
            else
                result = "IMPAR";
            if(play1 == result)
                Console.WriteLine(player1);
            else if(play2 == result)
                Console.WriteLine(player2);

        }
    }
}
