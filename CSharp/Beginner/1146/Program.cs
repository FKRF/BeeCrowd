using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int x = -1;

        while (x != 0)
        {
            x = Convert.ToInt32(Console.ReadLine());
            StringBuilder lineNumbers = new StringBuilder("1");
            if (x != 0)
            {
                for (int i = 2; i <= x; i++)
                {
                    if (i == x)
                        lineNumbers.Append(" " + i);
                    else
                        lineNumbers.Append(" " + i);
                }
                Console.WriteLine(lineNumbers);
            }

        }
    }
}
