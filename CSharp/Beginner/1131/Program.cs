class Program
{
    static void Main(string[] args)
    {
        int goalsInter, goalsGremio, newGrenal = 1, grenais = 0, victoriesInter = 0, victoriesGremio = 0, draws = 0;

        while (newGrenal == 1)
        {
            string[] line = Console.ReadLine().Split(' ');
            goalsInter = Convert.ToInt32(line[0]);
            goalsGremio = Convert.ToInt32(line[1]);
            if (goalsInter == goalsGremio)
                draws++;
            if (goalsInter > goalsGremio)
                victoriesInter++;
            if (goalsInter < goalsGremio)
                victoriesGremio++;
            grenais++;


            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            newGrenal = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"{grenais} grenais");
        Console.WriteLine($"Inter:{victoriesInter}");
        Console.WriteLine($"Gremio:{victoriesGremio}");
        Console.WriteLine($"Empates:{draws}");
        string winner = (victoriesInter > victoriesGremio) ? "Inter venceu mais" : "Gremio venceu mais";
        Console.WriteLine(winner);


    }
}
