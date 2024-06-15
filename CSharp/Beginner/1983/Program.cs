class Program
{
    static void Main(string[] args)
    {
        string[] line;
        int registrationNumber, registrationNumberMax;
        double grade, gradeMax;

        int n = Convert.ToInt32(Console.ReadLine());

        line = Console.ReadLine().Split(' ');
        registrationNumberMax = Convert.ToInt32(line[0]);
        gradeMax = Convert.ToDouble(line[1]);

        for(int i = 1; i < n; i++)
        {
            line = Console.ReadLine().Split(' ');
            registrationNumber = Convert.ToInt32(line[0]);
            grade = Convert.ToDouble(line[1]);
            if (grade > gradeMax)
            {
                gradeMax = grade;
                registrationNumberMax = registrationNumber;
            }
        }
        if(gradeMax >= 8)
            Console.WriteLine($"{registrationNumberMax}");
        else
            Console.WriteLine("Minimum note not reached");
    }
}
