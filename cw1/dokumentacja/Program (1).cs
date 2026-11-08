Console.WriteLine("Program, w którym odgadujesz losowo wygenerowaną liczbę");
Random rng = new Random();
int los = rng.Next(1, 101);
int num = 0;

do
{
    Console.WriteLine("Zgadnij liczbę od 1 do 100: ");
    num = int.Parse(Console.ReadLine());
    
    if (num > los)
            {
                Console.WriteLine("Za dużo!");
            }
            else if (num < los)
            {
                Console.WriteLine("Za mało!");
            }
            else
            {
                Console.WriteLine("Brawo! Zgadłeś!");
            }

}
while(num != los);