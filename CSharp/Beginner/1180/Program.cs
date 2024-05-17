class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] myArray = new int[n];
        string[] line = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
            myArray[i] = Convert.ToInt32(line[i]);

        int smaller = myArray[0];
        int pos = 0;
        for (int j = 1; j < n; j++)
        {
            if (smaller > myArray[j])
            {
                smaller = myArray[j];
                pos = j;
            }
        }

        Console.WriteLine($"Menor valor: {smaller}");
        Console.WriteLine($"Posicao: {pos}");
    }
}
