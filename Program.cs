class Program
{
    static void Main(string[] args)
    {
        // Метод для безопасного ввода координат
        double[] ReadPoint(string pointName)
        {
            double x, y;
            while (true)
            {
                Console.WriteLine($"Enter the coordinates of the {pointName} point (x y): ");
                string[] input = Console.ReadLine().Split(' ');

                if (input.Length == 2 &&
                    double.TryParse(input[0], out x) &&
                    double.TryParse(input[1], out y))
                {
                    return new double[] { x, y };
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter two numeric values separated by a space.");
                }
            }
        }

        // Read 3 points from the user
        double[] point1 = ReadPoint("first");
        double[] point2 = ReadPoint("second");
        double[] point3 = ReadPoint("third");

        double x1 = point1[0], y1 = point1[1];
        double x2 = point2[0], y2 = point2[1];
        double x3 = point3[0], y3 = point3[1];

        // Calculate the distance between the points
        double distance1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double distance2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double distance3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

        Console.WriteLine($"Distance between point 1 and point 2: {distance1}");
        Console.WriteLine($"Distance between point 2 and point 3: {distance2}");
        Console.WriteLine($"Distance between point 3 and point 1: {distance3}");

        // Check if points form a triangle with a right angle using Pythagorean theorem
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

        // Calculate the area of the triangle using Heron's formula
        double s = (distance1 + distance2 + distance3) / 2;
        double area = Math.Sqrt(s * (s - distance1) * (s - distance2) * (s - distance3));
        Console.WriteLine($"Area of the triangle: {area}");
    }
}
