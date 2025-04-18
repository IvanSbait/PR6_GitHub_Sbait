class Program
{
    static void Main(string[] args)
    {
        // read 4 points from the user
        Console.WriteLine("Enter the coordinates of the first point (x1 y1): ");
        string[] point1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(point1[0]);
        double y1 = double.Parse(point1[1]);

        Console.WriteLine("Enter the coordinates of the second point (x2 y2): ");
        string[] point2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(point2[0]);
        double y2 = double.Parse(point2[1]);

        Console.WriteLine("Enter the coordinates of the third point (x3 y3): ");
        string[] point3 = Console.ReadLine().Split(' ');
        double x3 = double.Parse(point3[0]);
        double y3 = double.Parse(point3[1]);

        // calculate the distance between the points
        double distance1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double distance2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double distance3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));


        Console.WriteLine($"Distance between point 1 and point 2: {distance1}");
        Console.WriteLine($"Distance between point 2 and point 3: {distance2}");
        Console.WriteLine($"Distance between point 3 and point 1: {distance3}");

        // check if points form a triagle with a right angle using Pythagorean theorem
        if (Math.Abs(distance1 * distance1 + distance2 * distance2 - distance3 * distance3) < 0.0001 ||
            Math.Abs(distance2 * distance2 + distance3 * distance3 - distance1 * distance1) < 0.0001 ||
            Math.Abs(distance3 * distance3 + distance1 * distance1 - distance2 * distance2) < 0.0001)
        {
            Console.WriteLine("The points form a right triangle.");
        }
        else
        {
            Console.WriteLine("The points do not form a right triangle.");
        }
    }
}
