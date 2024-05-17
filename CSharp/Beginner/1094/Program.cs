class Program
{
    static void Main(string[] args)
    {
        int n, animalQuantity;
        int[] animals = { 0, 0, 0 };
        string animalType;

        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] experiment = Console.ReadLine().Split(' ');
            animalQuantity = Convert.ToInt32(experiment[0]);
            animalType = experiment[1];
            switch (animalType)
            {
                case "C":
                    animals[0] += animalQuantity;
                    break;
                case "R":
                    animals[1] += animalQuantity;
                    break;
                case "S":
                    animals[2] += animalQuantity;
                    break;

            }
        }
        int animalsTotal = animals.Sum();
        float animalsTotalFloat = (float)animalsTotal;
        float[] animalsPerc = { (100.0f * animals[0]) / animalsTotal, (100.0f * animals[1]) / animalsTotal, (100.0f * animals[2]) / animalsTotal };

        Console.WriteLine($"Total: {animalsTotal} cobaias");
        Console.WriteLine($"Total de coelhos: {animals[0]}");
        Console.WriteLine($"Total de ratos: {animals[1]}");
        Console.WriteLine($"Total de sapos: {animals[2]}");
        Console.WriteLine($"Percentual de coelhos: {animalsPerc[0]:0.00} %");
        Console.WriteLine($"Percentual de ratos: {animalsPerc[1]:0.00} %");
        Console.WriteLine($"Percentual de sapos: {animalsPerc[2]:0.00} %");
    }
}
