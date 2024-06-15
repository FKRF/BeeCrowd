class Program
{
    static void Main(string[] args)
    {
        int height, n, result = 0;
        string[] line1, line2;

        line1 = Console.ReadLine().Split(' ');
        height = Convert.ToInt32(line1[0]);
        n = Convert.ToInt32(line1[1]);
        int[] heights = new int[n];
        

        line2 = Console.ReadLine().Split(' ');  
        
        heights[0] = Convert.ToInt32(line2[0]);  
        for (int i = 1; i < n; i++)
        {
            heights[i] = Convert.ToInt32(line2[i]);  
            if ( height < Math.Abs(heights[i] - heights[i - 1]))
            {
                result = 1;
                break;
            }
                
        }
        if(result == 0)
            Console.WriteLine("YOU WIN");
        else
            Console.WriteLine("GAME OVER");
    }
}
