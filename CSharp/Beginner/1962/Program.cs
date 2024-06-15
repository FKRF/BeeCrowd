using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int year, yearEvent;
        bool beforeChrist;
        StringBuilder yearOutput = new StringBuilder();
        for(int i = 0; i < n; i++)
        {
            yearOutput.Clear();
            year = Convert.ToInt32(Console.ReadLine());
            beforeChrist = year >= 2015 ? true : false;
            yearEvent =  beforeChrist == true ? year - 2015 + 1 : 2015 - year;
            yearOutput.Append(yearEvent);        
            yearOutput.Append((beforeChrist == true ? " A.C." : " D.C."));
            Console.WriteLine(yearOutput);
            
                
        }
    }
}
