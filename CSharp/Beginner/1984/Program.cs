class Program
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        string numberInverted = "";
        for(int i = number.Length - 1; i >= 0; i--)
        {
            numberInverted += number[i];
        }
        Console.WriteLine(numberInverted);
    }
}
