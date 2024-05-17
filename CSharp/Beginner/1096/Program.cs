using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        int i, j;
        for(i=1, j=7; i <= 9;)
        {
            Console.WriteLine($"I={i} J={j}");
            j--;
            if(j==4)
            {
                j = 7;
                i += 2;
            }
            
        }

    }

}