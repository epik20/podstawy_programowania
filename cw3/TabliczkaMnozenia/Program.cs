Console.Write("Podaj liczbę: ");
int liczba = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(liczba + " x " + i + " = " + (liczba * i));
}