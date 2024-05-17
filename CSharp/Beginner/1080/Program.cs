class Program
{
    static void Main()
    {
        int maxNumber, value, maxIndex;
        value = Convert.ToInt32(Console.ReadLine());
        maxNumber = value;
        maxIndex = 1;
        for (int i = 1; i < 100; i++)
        {
            value = Convert.ToInt32(Console.ReadLine());
            if (value > maxNumber)
            {
                maxNumber = value;
                maxIndex = i + 1;
            }
        }


        Console.WriteLine(maxNumber + "\n" + maxIndex);
    }
}
