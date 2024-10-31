using System;
using System.Text;

class Program
{
    static void Main()
    {
        string encryptedText = "ПВАНЩОАЕИНРИЫЯТЗТЫАНРИИСРРТГЕДХВСРЕМСЫУЯТЯАМОАДАИЛЯУЛИСЕШЗЫТКОРПАННЯРШЬИНЕАНХТНИЕЧНЕЮАИН";
        for (int stepLength = 1; stepLength <= 30; stepLength++)
        {
            Console.WriteLine($"Расшифровка для длины ступеньки {stepLength}:");
            string decryptedText = DecryptLadderCipher(encryptedText, stepLength);
            Console.WriteLine(decryptedText);
            Console.WriteLine();
        }
    }

    static string DecryptLadderCipher(string text, int stepLength)
    {
        int length = text.Length;
        int rows = (length + stepLength - 1) / stepLength;
        char[,] grid = new char[rows, stepLength];

        // Заполняем сетку по столбцам
        int index = 0;
        for (int col = 0; col < stepLength; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                if (index < length)
                {
                    grid[row, col] = text[index++];
                }
            }
        }

        // Считываем текст по строкам
        StringBuilder decryptedText = new StringBuilder();
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < stepLength; col++)
            {
                if (grid[row, col] != '\0')
                {
                    decryptedText.Append(grid[row, col]);
                }
            }
        }

        return decryptedText.ToString();
    }
}