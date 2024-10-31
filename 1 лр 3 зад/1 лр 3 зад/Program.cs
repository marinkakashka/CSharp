using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите координаты первой вершины (x1, y1): ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координаты второй вершины (x2, y2): ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());
        double sideLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) / Math.Sqrt(2);
        double area = Math.Pow(sideLength, 2);

        Console.WriteLine($"Площадь квадрата: {area}");
    }
}
