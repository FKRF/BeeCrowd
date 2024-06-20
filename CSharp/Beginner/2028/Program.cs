using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string eof, numberWord;
        StringBuilder sequence = new StringBuilder();
        StringBuilder sequenceOutput = new StringBuilder();
        int number, i, j, sum, index = 0;
        while( (eof = Console.ReadLine()) != null )
        {
            sequence.Clear();
            sequenceOutput.Clear();
            sequence.Append("0");
            number = Convert.ToInt32(eof);
            index += 1;
            for(i = 1, sum = 1; i <= number; i++)
            {
                for(j = 0; j < i; j++)
                {
                    sequence.Append((" " + i));
                    sum += 1;
                }
            }
            numberWord = number == 0 ? "numero" : "numeros";
            sequenceOutput.Append($"Caso {index}: {sum} {numberWord}\n" + sequence + "\n");
            Console.WriteLine(sequenceOutput);
        }
    }
}
