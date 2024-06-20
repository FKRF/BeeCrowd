using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbersMultiples = new int[4];
        string[] line = Console.ReadLine().Split(' ');
        int number;
        for(int i = 0; i < n; i++)
        {
            number = Convert.ToInt32(line[i]);
            if(number % 2 == 0)
                numbersMultiples[0] += 1;
            if(number % 3 == 0)
                numbersMultiples[1] += 1;
            if(number % 4 == 0)
                numbersMultiples[2] += 1;
            if(number % 5 == 0)
                numbersMultiples[3] += 1;
        }
        StringBuilder Multiples = new StringBuilder($"{numbersMultiples[0]} Multiplo(s) de 2\n{numbersMultiples[1]} Multiplo(s) de 3\n{numbersMultiples[2]} Multiplo(s) de 4\n{numbersMultiples[3]} Multiplo(s) de 5");
        Console.WriteLine(Multiples);
    }
}
