class Program
{
    static void Main(string[] args)
    {
        string line;
        int i;
        int sum = 0;
        while( (line = Console.ReadLine()) != null)
        {
            
            if(line[0] != 'c')
            {
                for(i = 0; i < 3; i++)    
                    if(line[2-i] == '*')
                        sum += (int) Math.Pow(2, i);
            }
            else 
            {
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
