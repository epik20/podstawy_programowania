Console.Write("Ile ocen chcesz wprowadzić? ");
int ile = int.Parse(Console.ReadLine());

int suma = 0;
int najwyzsza = 1;
int najnizsza = 6;
int pozytywne = 0;

for (int i = 1; i <= ile; i++)
{
    Console.Write("Podaj ocenę: ");
    int ocena = int.Parse(Console.ReadLine());

    suma += ocena;

    if (ocena > najwyzsza)
    {
        najwyzsza = ocena;
    }

    if (ocena < najnizsza)
    {
        najnizsza = ocena;
    }

    if (ocena >= 3)
    {
        pozytywne++;
    }
}

double srednia = (double)suma / ile;

Console.WriteLine();
Console.WriteLine("Średnia: " + srednia.ToString("F2"));
Console.WriteLine("Najwyższa ocena: " + najwyzsza);
Console.WriteLine("Najniższa ocena: " + najnizsza);
Console.WriteLine("Liczba ocen pozytywnych: " + pozytywne);