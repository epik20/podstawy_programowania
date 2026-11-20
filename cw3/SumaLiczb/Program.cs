Console.WriteLine("Program do sumowania kolejnych liczb");
Console.WriteLine("Podaj liczbę: ");

// Pobranie liczby
int num = int.Parse(Console.ReadLine());

// Sumowanie liczb
int suma = 0;
for (int i = 1; i <= num; i++)
{
    suma += i;
}
Console.WriteLine($"Suma liczb od 1 do {num} wynosi {suma}");