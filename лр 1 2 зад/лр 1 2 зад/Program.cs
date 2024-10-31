using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        string message = (number < 100 || number > 999)
            ? "Введите трехзначное число."
            : (SumOfDigits(number) % 10 == 2)
                ? "Сумма цифр числа заканчивается на 2."
                : "Сумма цифр числа не заканчивается на 2.";

        Console.WriteLine(message);
    }

    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
