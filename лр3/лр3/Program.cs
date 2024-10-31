Console.WriteLine("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите h: ");
int h = int.Parse(Console.ReadLine());

Console.WriteLine("x    y");
double y;
for (int i = a; i <= b; i += h)
{

    if (i > -6 && i < 6)
    {
        if ((Math.Pow(i, 2) + 2 * i - 15) == 0) Console.WriteLine($"{i}  На ноль делить нельзя!!!");

        else
        {
            y = 1 / (Math.Pow(i, 2) + 2 * i - 15);
            Console.WriteLine($"{i}    {y}");
        }

    }
    else if (i < -7)
    {
        if (i + 8 < 0) Console.Write($"{i}  Из отрицательного числа нельзя вычесть корень!!!");

        else
        {
            y = Math.Sqrt(i + 8);
            Console.WriteLine($"{i}    {y}");
        }

    }
    else if (i >= 10)
    {
        y = i ^ 3;
        Console.WriteLine($"{i}    {y}");
    }

    else Console.WriteLine($"{i}  x не входит не в один интервал ");

}
