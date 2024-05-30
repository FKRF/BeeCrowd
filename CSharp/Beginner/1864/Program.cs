using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string quote = "LIFE IS NOT A PROBLEM TO BE SOLVED";
        StringBuilder text = new StringBuilder();
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++)
            text.Append(quote[i]);
        Console.WriteLine(text);
    }
}
