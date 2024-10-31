using System;

class Program
{
    static void Main()
    {
        //ввод координат точки
        Console.WriteLine("Введите координаты точки (x, y):");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        //проверяем находится ли точка внутри одного из прямоугольников
        if ((x > 0 && x < 4) && (y > 2 && y < 5) ||
            (x < 0 && x > -7) && (y < -3 && y > -5))
        {
            Console.WriteLine("Да");
        }
        //проверяем находится ли точка снаружи прямоугольников
        else if ((y < 2 && y > 0) || y > 5 ||
                 (y > -3 && y < 0) || y < -5)
        {
            Console.WriteLine("Нет");
        }
        //в других случаях, точка находится на границе
        else
        {
            Console.WriteLine("На границе");
        }
    }
}
