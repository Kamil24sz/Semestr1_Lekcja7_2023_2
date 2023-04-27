using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semestr1_Lekcja7_2023_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj symbol lub liczbę otomową pierwiastka");
            string danePierwiastka = Console.ReadLine();
            // H  -> wodór      1  ->   wodór
            if (danePierwiastka == "H" || danePierwiastka == "1")
            {
                Console.WriteLine("Twój pierwiastek to wodór");
            }
            else if (danePierwiastka == "Co" || danePierwiastka == "27")
            {
                Console.WriteLine("Twój pierwiastek to kobalt");
            }
            else if (danePierwiastka == "K" || danePierwiastka == "19")
            {
                Console.WriteLine("Twój pierwiastek to potas");
            }
            else if (danePierwiastka == "Ag" || danePierwiastka == "47")
            {
                Console.WriteLine("Twój pierwiastek to srebro");
            }
            else if (danePierwiastka == "Au" || danePierwiastka == "79")
            {
                Console.WriteLine("Twój pierwiastek to złoto");
            }
            else if (danePierwiastka == "Mg" || danePierwiastka == "12")
            {
                Console.WriteLine("Twój pierwiastek to magnez");
            }
            else if (danePierwiastka == "He" || danePierwiastka == "2")
            {
                Console.WriteLine("Twój pierwiastek to hel");
            }

            Console.Clear();

            // imitujemy sklep internetowy (2-3 produkty)
            // dajemy możliwość użycia kodu rabatowego (ustawiamy go na początku)
            // kod obniża cenę o 15%

            string produkt1 = "Mysz Razer";
            string produkt2 = "Klawiatura Logitech";

            decimal cena1 = 399.99m;
            decimal cena2 = 199.99m;

            const string kodPromocyjny = "Giganci2023";

            // 1.Wyświetlić produkty i spytać użytkownika który produkt wybiera
            // 2.Musimy zapytać o kod promocyjny, jeśli user poda prawidłowy
            // to obniżamy cenę o 15% i ją wyświetlamy
            // jeśli nie prawidłowy to podajmeny normalną cenę

            Console.WriteLine("Witaj w naszym sklepie internetowym");
            Console.WriteLine($"1.{produkt1} - cena: {cena1}");
            Console.WriteLine($"2.{produkt2} - cena: {cena2}");
            Console.WriteLine("Wybierz interesujący Cię produkt [1-2]:");
            int wybór = int.Parse(Console.ReadLine());
            decimal koszyk = 0;

            Console.Clear();

            if(wybór == 1)
            {
                Console.WriteLine("Doskonały wybór!");
                koszyk = koszyk + cena1;
            }
            else if(wybór == 2)
            {
                Console.WriteLine("Doskonały wybór!");
                koszyk = koszyk + cena2;
            }
            else
            {
                Console.WriteLine("Wybrałeś produkt z poza listy!");
            }

            Console.WriteLine("Podaj kod rabatowy.");
            string kodOdUsera = Console.ReadLine();
            if(kodPromocyjny == kodOdUsera)
            {
                koszyk = koszyk * 0.85m;
            }

            Console.WriteLine($"Cena końcowa to {Math.Round(koszyk, 2)}");


            // Tworzymy prostą aplikację konsolową imitującą quiz, 2-3 pytania i po 4 odpowiedzi a b c d
            // Wyświetlamy pojedynczo pytanie, pytamy użytkownika o poprawną odpowiedź i jeśli odpowiedź jest poprawna
            // dodajemy mu punkt
            // wymyślamy własne pytania związane ze światem IT
            Console.Clear();

            Console.WriteLine("Witaj w Wuizie Giganci!");
            int punkty = 0;
            string odp;

            Console.WriteLine("Pytanie 1");
            Console.WriteLine("Który z podanych nie jest językiem programowania");
            Console.WriteLine("A - Java");
            Console.WriteLine("B - C#");
            Console.WriteLine("C - HTML");
            Console.WriteLine("D - Python");

            odp = Console.ReadLine();
            if(odp.ToUpper() == "C")
            {
                Console.WriteLine("Doskonale to prawidłowa odpowiedź");
                punkty++; // inkrementacja - to samo co punkty = punkty + 1;
            }
            else
            {
                Console.WriteLine("Niestety to nie była poprawna odpowiedź");
            }
            // ta funkcja robi pauzę w programie na okroeśloną liczbę milisekund 1000ms = 1s
            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("Pytanie 2");
            Console.WriteLine("Który z podanych nie jest systemem operacyjnym");
            Console.WriteLine("A - Windows");
            Console.WriteLine("B - Linux");
            Console.WriteLine("C - Android");
            Console.WriteLine("D - Microsoft");

            odp = Console.ReadLine();
            if (odp.ToUpper() == "D")
            {
                Console.WriteLine("Doskonale to prawidłowa odpowiedź");
                punkty++; // inkrementacja - to samo co punkty = punkty + 1;
            }
            else
            {
                Console.WriteLine("Niestety to nie była poprawna odpowiedź");
            }

            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("Pytanie 3");
            Console.WriteLine("Co to jest zip?");
            Console.WriteLine("A - rodzaj kodeka muzycznego");
            Console.WriteLine("B - rozszerzenie obrazka");
            Console.WriteLine("C - format kompresji plików");
            Console.WriteLine("D - rozszerzenie dźwiękowe");

            odp = Console.ReadLine();
            if (odp.ToUpper() == "C")
            {
                Console.WriteLine("Doskonale to prawidłowa odpowiedź");
                punkty++; // inkrementacja - to samo co punkty = punkty + 1;
            }
            else
            {
                Console.WriteLine("Niestety to nie była poprawna odpowiedź");
            }

            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("KONIEC QUIZU");
            Console.WriteLine($"Udało Ci się zdobyć {punkty}/3");
            if(punkty == 3)
            {
                Console.WriteLine("Jesteś mistrzem IT!");
            }

            Console.ReadLine();
        }
    }
}
