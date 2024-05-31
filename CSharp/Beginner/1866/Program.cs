class Program
{
    static void Main(string[] args)
    {
        int n, s, sum;
        int c = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < c; i++)
        {
            n = Convert.ToInt32(Console.ReadLine());
            s = 1;
            sum = 0;
            for(int j = 1; j <= n; j++)
            {
                sum += s; 
                s *= -1;
                
            }
            Console.WriteLine(sum);
        }
    }
}
