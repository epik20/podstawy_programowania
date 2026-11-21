Console.Write("Podaj wysokość trójkąta: ");
int wysokosc = int.Parse(Console.ReadLine());

for (int i = 1; i <= wysokosc; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}