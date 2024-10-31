int a = 6;
int b = 6;

int chislo = 1;
int c = chislo;

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        if (i == j)
        {
            Console.Write(c + "  ");
            c++;
        }
        else
        {
            Console.Write(chislo + "  ");
        }

    }
    Console.WriteLine();
}
