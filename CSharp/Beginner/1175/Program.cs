class Program
{
    static void Main(string[] args)
    {
        int[] myArray = new int[20];
        int i, j, aux;

        for (i = 0; i < 20; i++)
            myArray[i] = Convert.ToInt32(Console.ReadLine());

        for (i = 0, j = 19; j - i >= 1; i++, j--)
        {
            aux = myArray[i];
            myArray[i] = myArray[j];
            myArray[j] = aux;
        }
        for (i = 0; i < 20; i++)
            Console.WriteLine($"N[{i}] = {myArray[i]}");
    }
}
