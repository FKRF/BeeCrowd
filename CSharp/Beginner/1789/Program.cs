class Program
{
    static void Main(string[] args)
    {
        string EOF;
        int nSlugs, i, greater, aux;
        string[] line;
        while( (EOF = Console.ReadLine()) != null )
        {
            nSlugs = Convert.ToInt32(EOF);
            line = Console.ReadLine().Split(' ');
            greater = Convert.ToInt32(line[0]);
            for(i = 1; i < nSlugs; i++)
            {
                aux = Convert.ToInt32(line[i]);
                if (aux > greater)
                    greater = aux;
            }
            Console.WriteLine(LevelSlug(greater));

        }
    }

    static int LevelSlug(int n)
    {
        if(n < 10)
            return 1;
        else if (n > 10 && n < 20)
            return 2;
        else if (n >= 20)
            return 3;
        else
            return -1;
    }
}
