using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите координату x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        string result;

        // Первая заштрихованная область (первый квадрант)
        if (x >= 0 && y >= 2 && y <= 5)
        {
            if (x == 0 || y == 2 || y == 5)
                result = "На границе";
            else
                result = "Да";
        }
        // Вторая заштрихованная область (четвертый квадрант)
        else if (x >= -7 && x <= 0 && y >= -3 && y <= 0)
        {
            if (x == -7 || x == 0 || y == -3 || y == 0)
                result = "На границе";
            else
                result = "Да";
        }
        // Если точка не попадает ни в одну из областей
        else
        {
            result = "Нет";
        }

        Console.WriteLine(result);
    }
}
