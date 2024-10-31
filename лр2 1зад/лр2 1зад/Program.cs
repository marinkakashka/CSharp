using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());

        double y;

        if (((x - 15) * (x + 2)) == 0) //проверка не равен ли знаменатель нулю
        {
            y = 0; //если знаменатель равен нулю, то y равен 0
        }
        else
        {
            y = x / ((x - 15) * (x + 2));  //если знаменатель не равен нулю, вычисляем значение функции y
        }

        Console.WriteLine($"Значение функции y при x = {x} равно {y}"); //вывод
    }
}