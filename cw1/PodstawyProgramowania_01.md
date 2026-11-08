# Podstawy Programowania
Zajęcia 04.2026.
Termin realizacji 16.10.2026 EOD

## Polecenie

0.      Zapoznaj się z podstawą MarkDown.

1.	Zainstaluj Visual Studio Code i Visual Studio.
2.	Używając C# rozwiąż zadanie Kalkulator oceny.
3.	Używając C# rozwiąż zadanie Zgadnij liczbę (opcjonalne)
4.	Uruchom program w obu zainstalowanych IDE. Kod źródłowy i zrzut ekranu z wykoania, wyślij na email: pczapiewski@pjwstk.edu.pl
	W tytul emaila napisz Podstawy Programowania - swoje imię
5.	Przygotuj się do prezetnacji rozwiązania.
    Załóż konto na https://github.com/login
	Stwórz swoje własne repozytorium. Dodaj prowadzącego do niego.

## Zadanie: Kalkulator oceny
Napisz program w C#, który:
* Poprosi użytkownika o podanie imienia.
* Poprosi o podanie trzech ocen (liczby całkowite od 1 do 6).
* Obliczy średnią ocen.
* Wyświetli imię ucznia oraz jego średnią.
* Sprawdzi, czy uczeń zaliczył przedmiot:
    średnia ≥ 3.0 -> Zaliczone
    średnia < 3.0 -> Niezaliczone

Przykład działania
```
Podaj imię: Jan
Podaj pierwszą ocenę: 4
Podaj drugą ocenę: 3
Podaj trzecią ocenę: 5

Jan, Twoja średnia to: 4.00
Zaliczone!
```

## Zadanie: Zgadnij liczbę
Napisz program w C#, który:
* Losuje liczbę od 1 do 100.
* Prosi użytkownika o odgadnięcie liczby.
  Jeśli podana liczba jest:
    za mała → wyświetla Za mało!
    za duża → wyświetla Za dużo!
    poprawna → wyświetla Brawo! Zgadłeś!

Program powinien powtarzać pytanie, dopóki użytkownik nie zgadnie liczby.
Przykład
```
Zgadnij liczbę od 1 do 100: 50
Za dużo!

Zgadnij liczbę od 1 do 100: 25
Za mało!

Zgadnij liczbę od 1 do 100: 37
Brawo! Zgadłeś!
```
Podpowiedź: przyda Ci się Random, while oraz if / else.