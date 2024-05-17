class Program
{
    static void Main(string[] args)
    {
        long[] fibonacciSequence = new long[60];
        fibonacciSequence[0] = 0;
        fibonacciSequence[1] = 1;
        for (int i = 2; i < 60; i++)
            fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];

        int n = Convert.ToInt32(Console.ReadLine());
        int x;
        for (int i = 0; i < n; i++)
        {
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Fib({x}) = {fibonacciSequence[x]}");
        }


    }

    
}
