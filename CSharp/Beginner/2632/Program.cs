using System;
class Program
{
    static void Main(string[] args)
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        int[] damage = new int[n];

        int[,] vertex = new int[4, 2];
        int x0, y0, w, h;
        int level;
        int cx, cy;

        string element;
        for (int i = 0; i < n; i++)
        {
            string[] line1 = Console.ReadLine().Split(' ');

            w = Convert.ToInt32(line1[0]);
            h = Convert.ToInt32(line1[1]);
            x0 = Convert.ToInt32(line1[2]);
            y0 = Convert.ToInt32(line1[3]);

            vertex[0, 0] = x0;
            vertex[0, 1] = y0;
            vertex[1, 0] = x0 + w;
            vertex[1, 1] = y0;
            vertex[2, 0] = x0;
            vertex[2, 1] = y0 + h;
            vertex[3, 0] = x0 + w;
            vertex[3, 1] = y0 + h;

            string[] line2 = Console.ReadLine().Split(' ');

            element = line2[0];
            level = Convert.ToInt32(line2[1]);
            cx = Convert.ToInt32(line2[2]);
            cy = Convert.ToInt32(line2[3]);

            int[,] spellsNumbers = { { 200, 20, 30, 50 }, { 300, 10, 25, 40 }, { 400, 25, 55, 70 }, { 100, 18, 38, 60 } };
            int elementNumber = -1;

            switch (element)
            {
                case "fire":
                    elementNumber = 0;
                    break;
                case "water":
                    elementNumber = 1;
                    break;
                case "earth":
                    elementNumber = 2;
                    break;
                case "air":
                    elementNumber = 3;
                    break;
            }

            int numberPoints = 60;
            double[,] circleRegion = new double[numberPoints, numberPoints];

            Program.CreateCirclePoints(circleRegion, spellsNumbers[elementNumber, level], cx, cy, numberPoints);

            for (int k = 0; k < 4; k++)
            {
                if (IsInsideCircle(spellsNumbers[elementNumber, level], cx, cy, vertex[k, 0], vertex[k, 1], numberPoints) == 1)
                {
                    damage[i] = spellsNumbers[elementNumber, 0];
                    break;
                }
                else if (IsInsideRectangle(circleRegion, numberPoints, vertex, cx, cy, spellsNumbers[elementNumber, level]) == 1)
                {
                    damage[i] = spellsNumbers[elementNumber, 0];
                    break;
                }

            }

        }

        for (int i = 0; i < n; i++)
            Console.WriteLine(damage[i]);

    }

    public static void CreateCirclePoints(double[,] circleRegion, int radius, int centerAreaX, int centerAreaY, int numberPoints)
    {
        double minAngle = 360.0 / numberPoints;
        double[] angles = new double[numberPoints];
        for (int i = 0; i < numberPoints; i++)
            angles[i] = ((minAngle * i) * Math.PI) / 180;


        for (int i = 0; i < numberPoints; i++)
        {
            circleRegion[i, 0] = radius * Math.Cos(angles[i]) + centerAreaX;
            circleRegion[i, 1] = radius * Math.Sin(angles[i]) + centerAreaY;
        }
    }

    public static int IsInsideCircle(int radius, int centerAreaX, int centerAreaY, int vertexHorInt, int vertexVertInt, int numberPoints)
    {
        double vertexHor = vertexHorInt;
        double vertexVert = vertexVertInt;

        int hit = 0;
        double dist;

        for (int i = 0; i < numberPoints; i++)
        {
            dist = Math.Sqrt(Math.Pow(vertexHor - centerAreaX, 2) + Math.Pow(vertexVert - centerAreaY, 2));
            if (dist <= radius)
                hit = 1;
        }

        return hit;
    }

    public static int IsInsideRectangle(double[,] circleRegion, int numberPoints, int[,] vertex, int centerAreaX, int centerAreaY, int radius)
    {
        int hit = 0;
        for (int i = 0; i < numberPoints; i++)
        {
            if (((circleRegion[i, 0] >= vertex[0, 0]) && (circleRegion[i, 0] <= vertex[1, 0])) && ((circleRegion[i, 1] >= vertex[0, 1]) && (circleRegion[i, 1] <= vertex[3, 1])))
            // if ((((centerAreaX + radius) >= vertex[0, 0]) && ((centerAreaX + radius) <= (vertex[1, 0]))) && (((centerAreaY + radius) >= vertex[0, 1]) && ((centerAreaY + radius) <= vertex[3, 1])))
            {
                hit = 1;
            }
        }
        return hit;
    }

}
