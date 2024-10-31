namespace лр_4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество членов последовательности: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите число: ");
                string chislo = Console.ReadLine();
                Console.WriteLine(Q(chislo));
            }
        }

        static string Q(string a)
        {
            string b = "";
            int length = 0;

            // Определяем длину строки
            foreach (char c in a)
            {
                length++;
            }

            // Переворачиваем строку
            for (int i = length - 1; i >= 0; i--)
            {
                b += a[i];
            }

            return b;
        }
    }
}