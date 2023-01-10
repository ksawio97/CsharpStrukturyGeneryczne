using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace _2_KolekcjeGeneryczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> pracownicy = new List<Pracownik>
            {
                new Pracownik { Imie = "Marcin", Nazwisko = "Nowak"},
                new Pracownik { Imie = "Jan", Nazwisko = "Nowak" },
                new Pracownik { Imie = "Tomasz", Nazwisko = "Nowak" }
            };

            foreach (var pracownik in pracownicy)
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            Console.WriteLine("---------");

            pracownicy.Add(new Pracownik { Imie = "Anatol", Nazwisko = "Koszyk" });

            for (int i = 0; i < pracownicy.Count; i++)
                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
        }
    }
}
