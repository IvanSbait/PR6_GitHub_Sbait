class Program
{
    static void Main(string[] args)
    {
        do
        {
            // Метод для безопасного ввода координат
            double[] ReadPoint(string pointName)
            {
                double x, y;
                while (true)
                {
                    Console.WriteLine($"Введите координаты {pointName} точки (x y): ");
                    string[] input = Console.ReadLine().Split(' ');

                    if (input.Length == 2 &&
                        double.TryParse(input[0], out x) &&
                        double.TryParse(input[1], out y))
                    {
                        return new double[] { x, y };
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод. Пожалуйста, введите два числовых значения, разделенных пробелом.");
                    }
                }
            }

            // Чтение 3 точек от пользователя
            double[] point1 = ReadPoint("первой");
            double[] point2 = ReadPoint("второй");
            double[] point3 = ReadPoint("третьей");

            double x1 = point1[0], y1 = point1[1];
            double x2 = point2[0], y2 = point2[1];
            double x3 = point3[0], y3 = point3[1];

            // Вычисление расстояния между точками
            double distance1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double distance2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double distance3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            Console.WriteLine($"Расстояние между точкой 1 и точкой 2: {distance1}");
            Console.WriteLine($"Расстояние между точкой 2 и точкой 3: {distance2}");
            Console.WriteLine($"Расстояние между точкой 3 и точкой 1: {distance3}");

            // Проверка, образуют ли точки прямоугольный треугольник с использованием теоремы Пифагора
            if (Math.Abs(distance1 * distance1 + distance2 * distance2 - distance3 * distance3) < 0.0001 ||
                Math.Abs(distance2 * distance2 + distance3 * distance3 - distance1 * distance1) < 0.0001 ||
                Math.Abs(distance3 * distance3 + distance1 * distance1 - distance2 * distance2) < 0.0001)
            {
                Console.WriteLine("Точки образуют прямоугольный треугольник.");
            }
            else
            {
                Console.WriteLine("Точки не образуют прямоугольный треугольник.");
            }

            // Вычисление площади треугольника с использованием формулы Герона
            double s = (distance1 + distance2 + distance3) / 2;
            double area = Math.Sqrt(s * (s - distance1) * (s - distance2) * (s - distance3));
            Console.WriteLine($"Площадь треугольника: {area}");

            Console.WriteLine("Хотите запустить программу снова? (да/нет): ");
        } while (Console.ReadLine().Trim().ToLower() == "да");
    }
}
