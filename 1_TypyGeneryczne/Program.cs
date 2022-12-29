using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    class Program
    {
        public static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);

            var wartosc = 0.0;
            while (double.TryParse(Console.ReadLine(), out wartosc))
                kolejka.Zapisz(wartosc);
            
            var suma = 0.0;
            while (!kolejka.JestPusty)
                    suma += kolejka.Czytaj();
            
            Console.WriteLine($"Suma: {suma}");


            var kolejkaOsob = new KolejkaKolowa<Osoba>();
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
    }

    public class Osoba
    {
        public string Imie { get; set; }

        public string Nazwisko { get; set; }
    }
}
