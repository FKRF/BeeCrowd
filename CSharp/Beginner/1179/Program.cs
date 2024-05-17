using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int i, j, x;
        int[] par = new int[5];
        int[] odd = new int[5];
        int parIndex = 0, oddIndex = 0;


        for (i = 0; i < 15; i++)
        {
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                par[parIndex] = x;
                parIndex++;
            }
            else
            {
                odd[oddIndex] = x;
                oddIndex++;
            }
            if (oddIndex > 4)
            {
                PrintArrayImpar(odd, ref oddIndex);
            }
            if (parIndex > 4)
            {
                PrintArrayPar(par, ref parIndex);
            }

        }
        if (oddIndex != 0)
            PrintArrayImpar(odd, ref oddIndex);
        if (parIndex != 0)
            PrintArrayPar(par, ref parIndex);


    }

    public static int ModNumber(int a, int b)
    {
        return (((a % b) + b) % b);
    }

    public static void PrintArrayImpar(int[] myArray, ref int index)
    {
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine($"impar[{i}] = {myArray[i]}");
        }
        index = 0;
    }

    public static void PrintArrayPar(int[] myArray, ref int index)
    {
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine($"par[{i}] = {myArray[i]}");
        }
        index = 0;
    }
}
