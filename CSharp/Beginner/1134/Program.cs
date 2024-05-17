class Program
{
    static void Main(string[] args)
    {
        int fuelType = -1;
        int[] fuelQuantity = new int[3];

        while (fuelType != 4)
        {
            fuelType = Convert.ToInt32(Console.ReadLine());
            switch (fuelType)
            {
                case 1:
                    fuelQuantity[0]++;
                    break;
                case 2:
                    fuelQuantity[1]++;
                    break;
                case 3:
                    fuelQuantity[2]++;
                    break;

            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {fuelQuantity[0]}");
        Console.WriteLine($"Gasolina: {fuelQuantity[1]}");
        Console.WriteLine($"Diesel: {fuelQuantity[2]}");
    }
}
