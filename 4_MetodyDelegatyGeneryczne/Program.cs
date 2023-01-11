using System;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        public static void Main(string[] args)
        {
            Action<bool> drukuj = x => Console.WriteLine(x);
            Func<int, int, int, int> sum3 = (x, y, z) => x + y + z;
            Func<int, int, int> multiplication = (a, b) => a * b;
            Predicate<int> jestMniejszeOdSto = d => d < 100;

            drukuj(jestMniejszeOdSto(multiplication(sum3(8, 10, 2), sum3(9, 2, 1))));

            var kolejka = new DuzaKolejka<double>();
            WprowadzanieDanych(kolejka);

            //zamiast lambdy mozesz jeszcze uzyc delegate lub Action
            kolejka.Drukuj(d => Console.WriteLine(d));

            var kolejkaOsob = new KolejkaKolowa<Osoba>();
            PrzetwarzanieDanych(kolejkaOsob);
        }

        private static void PrzetwarzanieDanych(IKolejka<Osoba> kolejkaOsob)
        {
            kolejkaOsob.Zapisz(new Osoba { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejkaOsob.Zapisz(new Osoba { Imie = "Tomek", Nazwisko = "Nowak" });
            kolejkaOsob.Zapisz(new Osoba { Imie = "Jacek", Nazwisko = "Nowak" });

            Osoba osoba;
            while (!kolejkaOsob.JestPusty)
            {
                osoba = kolejkaOsob.Czytaj();
                Console.WriteLine($"Osoba: {osoba.Imie} {osoba.Nazwisko}");
            }
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            var wartosc = 0.0;
            while (double.TryParse(Console.ReadLine(), out wartosc))
                kolejka.Zapisz(wartosc);

            var suma = 0.0;
            foreach (var item in kolejka)
                suma += item;

            Console.WriteLine($"Suma: {suma}");
        }
    }

    public class Osoba
    {
        public string Imie { get; set; }

        public string Nazwisko { get; set; }
    }
}
