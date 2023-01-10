using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace _2_KolekcjeGeneryczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pracownik[] pracownicy = new Pracownik[]
            {
                new Pracownik { Imie = "Marcin", Nazwisko = "Nowak"},
                new Pracownik { Imie = "Jan", Nazwisko = "Nowak" },
                new Pracownik { Imie = "Tomasz", Nazwisko = "Nowak" }
            };

            foreach (var pracownik in pracownicy)
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            Console.WriteLine("---------");

            Array.Resize(ref pracownicy, pracownicy.Length + 1);
            pracownicy[pracownicy.Length] = new Pracownik { Imie = "Anatol", Nazwisko = "Koszyk" };

            for (int i = 0; i < pracownicy.Length; i++)
                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
        }
    }
}
