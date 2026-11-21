Console.Write("Podaj liczbę: ");
int liczba = int.Parse(Console.ReadLine());

bool pierwsza = true;

if (liczba <= 1)
{
    pierwsza = false;
}
else
{
    for (int i = 2; i < liczba; i++)
    {
        if (liczba % i == 0)
        {
            pierwsza = false;
            break;
        }
    }
}

if (pierwsza == true)
{
    Console.WriteLine(liczba + " jest liczbą pierwszą.");
}
else
{
    Console.WriteLine(liczba + " nie jest liczbą pierwszą.");
}