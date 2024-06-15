class Program
{
    static void Main(string[] args)
    {
        int i, n = Convert.ToInt32(Console.ReadLine());
        string[] line = Console.ReadLine().Split(' ');
        Int64[] stars = new Int64[n];
        Int64 starsTotal = 0, starsStolenTotal = 0, starsAffected = 0;
        Int64[] starsStolen = new Int64[n];
        for(i = 0; i < n; i++)
        {
            stars[i] = Convert.ToInt64(line[i]);
            starsStolen[i] = stars[i];
            starsTotal += stars[i];
        }
            
        i = 0;
        while(true)
        {
            starsStolen[i] -= 1;
            starsStolenTotal += 1;
            i = (starsStolen[i]+1) % 2 == 1 ? (i + 1) : (i -1);
            if(i >= n || i < 0 || starsStolen[i] == 0)
                break; 
        }
        for(int j = 0; j < n; j++)
            if(stars[j] != starsStolen[j])
                starsAffected += 1;

        Console.WriteLine($"{starsAffected} {starsTotal - starsStolenTotal}");
    }

    
}
