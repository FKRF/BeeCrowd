class Program
{
    static void Main(string[] args)
    {
        int n1, n2;
        int n = Convert.ToInt32(Console.ReadLine());
        int[] sumVector = new int[n];
        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split();
            n1 = Convert.ToInt32(line[0]);
            n2 = Convert.ToInt32(line[1]);
            int aux;
            if (n1 > n2)
            {
                aux = n1;
                n1 = n2;
                n2 = aux;
            }

            for (int j = n1 + 1; j < n2; j++)
                if (j % 2 == 1)
                    sumVector[i] += j;

        }

        for (int i = 0; i < n; i++)
            Console.WriteLine(sumVector[i]);
    }
}
