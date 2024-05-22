using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int i, n = Convert.ToInt32(Console.ReadLine());
        StringBuilder hoHo = new StringBuilder();
        for(i = 0; i < n - 1; i++)
            hoHo.Append("Ho ");
        hoHo.Append($"Ho!");
        Console.WriteLine(hoHo);
    }
}
