using System;

namespace _3_KlasyIInterfejsyGeneryczne
{
    class Program
    {
        public static void Main(string[] args)
        {
            var kolejka = new DuzaKolejka<double>();
            WprowadzanieDanych(kolejka);

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
