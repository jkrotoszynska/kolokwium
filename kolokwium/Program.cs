using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wpisujący własne imię do pierwszego pola tablicy, nazwisko do drugiego (dowolną metodą!), i wyświetlający zawartość tej tablicy
            string[] ja = { "Justyna", "Krotoszyńska" };

            foreach (string element in ja)
            {
                Console.WriteLine(element);
            }

            // Wyświetlić (pętla for) wszystkie liczby z zakresu 0-1500 podzielne przez długość własnego imienia LUB nazwiska 
            // (żeby nie było wątpliwości - u mnie, gdybyśmy zaczynali od 1, byłoby to 7, 12, 14, 21, 24, 28...)
            string imie = "Justyna";
            string naziwsko = "Krotoszyńska";
            int dlugosc_imienia = imie.Length;
            int dlugosc_nazwiska = naziwsko.Length;

            for (int i = 0; i <= 1500; i++)
            {
                if (i % dlugosc_imienia == 0 || i % dlugosc_nazwiska == 0) Console.WriteLine(i);
            }
            

            // Napisać program symulujący wynik pojedynczego rzutu kostką w oparciu o generator liczb losowych
            Random kostka = new Random();
            int rzut = kostka.Next(1, 7);
            Console.WriteLine("Wyrzucono {0}", rzut);


            // Napisać program pobierający 2 integery od użytkownika i przechwytujący wyjątek dzielenia przez zero przy wyświetlaniu wyniku dzielenia jednego przez drugi
            try
            {
                Console.Write("Podaj pierwszy integer: ");
                int pierwszy = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj drugi integer: ");
                int drugi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wynik to: {0}", pierwszy / drugi);
            } 
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nie można podzielić przez zero!!!!");
            }
            
            // Napisać program, w którym za punkt wyjścia bierzemy liczbę, którą mają Państwo na teamsach w mailu w 
            //zakładce "kontakt" swojego profilu. Wyświetlamy wspomnianą liczbę i każdą o połowę mniejszą, aż osiągniemy miesiąc swojego urodzenia (pętla while).
            int numer = 998;
            int miesiac = 11;

            while (numer != miesiac)
            {
                numer = numer / 2;
                if (numer < miesiac)
                {
                    Console.WriteLine("Nie da się osiągnąć {0}", miesiac);
                    break;
                }
                Console.WriteLine(numer);
            }

            Console.ReadKey();

        }
    }
}
