class Program
{
    static void Main(string[] args)
    {
        int tea = Convert.ToInt32(Console.ReadLine());
        string[] line = Console.ReadLine().Split(' ');
        int answer, correctAnswers = 0;
        for(int i = 0; i < 5; i++)
        {
            answer = Convert.ToInt32(line[i]);
            if(answer == tea)
                correctAnswers++;

        }
        Console.WriteLine(correctAnswers);
    }
}
