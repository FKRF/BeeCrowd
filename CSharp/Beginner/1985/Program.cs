class Program
{
    static void Main(string[] args)
    {
        double[] productPrices =  {1.5, 2.5, 3.5, 4.5, 5.5};

        int n = Convert.ToInt32(Console.ReadLine());
        string[] line;
        double amountPurchase = 0;
        int product, quantity;
        for(int i = 0; i < n; i++)
        {
            line = Console.ReadLine().Split(' ');
            product = Convert.ToInt32(line[0]);
            quantity = Convert.ToInt32(line[1]);
            amountPurchase += productPrices[product - 1001]*quantity;
            
        }
        Console.WriteLine($"{amountPurchase:0.00}");
    }
}
