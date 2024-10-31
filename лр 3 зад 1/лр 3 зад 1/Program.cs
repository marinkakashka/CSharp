using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение A: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Введите значение B: ");
        int B = int.Parse(Console.ReadLine());

        if (A > B)
        {
            Console.WriteLine("A должно быть меньше или равно B");
        }
        else
        {
            for (int num = A; num <= B; num++)
            {
                if (num % 10 == 1 || num % 10 == 3 || num % 10 == 5 || num % 10 == 7 || num % 10 == 9)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
