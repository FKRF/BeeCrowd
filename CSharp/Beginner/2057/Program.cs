class Program
{
    static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split();
        int leftTime, travelTime, zoneTime, arrivalTime;
        leftTime = Convert.ToInt32(line[0]);
        travelTime = Convert.ToInt32(line[1]);
        zoneTime = Convert.ToInt32(line[2]);
        arrivalTime = leftTime + travelTime + zoneTime;
        arrivalTime = (arrivalTime >= 24 )? arrivalTime - 24 : arrivalTime;
        arrivalTime = (arrivalTime < 0 )? 24 + arrivalTime : arrivalTime;
        Console.WriteLine(arrivalTime);
    }
}
