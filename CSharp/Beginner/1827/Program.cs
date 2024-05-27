using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string eof;
        int n, i, j, nCentral;
        bool inner;
        StringBuilder myMatrix = new StringBuilder();
        while( (eof = Console.ReadLine()) != null )
        {
            n = Convert.ToInt32(eof);
            
            nCentral = n/2;
            myMatrix.Clear();
            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    inner = (i >= n/3) && j >= n/3 && i < n - n/3 && j < n - n/3;
                    if(i == nCentral && j == nCentral)
                        myMatrix.Append("4");
                    else if(inner == true)
                        myMatrix.Append("1");
                    else if(i == j)
                        myMatrix.Append("2");    
                    else if ( i + j == n -1)
                        myMatrix.Append("3");
                    else
                        myMatrix.Append("0");
                    
                        
                }
                myMatrix.Append("\n");
            }
            Console.WriteLine(myMatrix);

        }
    }

    
}
