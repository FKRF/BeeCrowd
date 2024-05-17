class Program
{
    static void Main(string[] args)
    {
        double i = 0, j = 0;
        int count, aux;
        for (count = 0, aux = 0; i <= 2.0; count++)
        {
            if (count <= 3 && aux == 0)
            {
                j += 1;
                if (count == 3)
                {
                    j -= 3;
                    i += 0.2;
                    j += 0.2;
                    count = 0;
                    aux = 1;
                }
                Program.PrintSequence(i, j);
            }


            if (count < 3 && aux == 1 && i <= 2.0)
            {
                j += 1;
                if (count == 2)
                {
                    j -= 3;
                    i += 0.2;
                    j += 0.2;
                    count = 0;
                    aux = 0;
                }
                Program.PrintSequence(i, j);
            }



        }
    }

    public static void PrintSequence(double i, double j)
    {
        string iNumber, jNumber;
        if (Math.Round(i, 1) - (Math.Round(i)) == 0)
            iNumber = (Math.Round(i)).ToString();
        else
            iNumber = i.ToString("0.0");

        if (Math.Round(j, 1) - (Math.Round(j)) == 0)
            jNumber = (Math.Round(j)).ToString();
        else
            jNumber = j.ToString("0.0");

        if (i <= 2)
            Console.WriteLine($"I={iNumber} J={jNumber}");
    }
}
