class Program
{
    static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(' ');
        int ta, tb, tc, tab, tbc;

        ta = Convert.ToInt32(line[0]);
        tb = Convert.ToInt32(line[1]);
        tc = Convert.ToInt32(line[2]);

        tab = tb - ta;
        tbc = tc - tb;

        string answer = (tbc > tab || (tab > 0 && tbc >= tab)) ? ":)" : ":(";
        Console.WriteLine(answer);
        
    }

}
