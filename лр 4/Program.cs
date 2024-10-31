namespace лр_4
{
    internal class Program
    {
        static void Main()
        {
            // Задание 1

            while (true)
            {
                Console.Write("Введите число: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(DO(x));
            }
        }
        static int DO(int a)
        {
            if (a % 2 != 0)
            {
                return a + 2;
            }
            else
            {
                return 1;
            }
        }

        // Задание 2
        //    Console.WriteLine("Введите количество членов последовательности: ");
        //    int N = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < N; i++)
        //    {
        //        Console.WriteLine("Введите число: ");
        //        string chislo = Console.ReadLine();
        //        Console.WriteLine(Q(chislo));
        //    }
        //}

        //static string Q(string a)
        //{
        //    string b = "";
        //    for (int i = a.Length - 1; i >= 0; i--)
        //    {
        //        b += a[i];
        //    }
        //    return b;
    }
    
}
