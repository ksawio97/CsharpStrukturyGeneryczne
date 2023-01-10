﻿using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolejka();
            Console.WriteLine();
            Stos();
            Console.WriteLine();
            HashSet();
        }

        private static void HashSet()
        {
            Console.WriteLine("HashSet:");
            HashSet<Pracownik> set = new HashSet<Pracownik>();

            var pracownik = new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" };
            set.Add(pracownik);
            set.Add(pracownik);
            set.Add(new Pracownik { Imie = "Zosia", Nazwisko = "Nowak" });
            set.Add(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });

            foreach (var item in set)
                Console.WriteLine(item.Imie);
        }

        private static void Stos()
        {
            Console.WriteLine("Stos:");

            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Marek", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Zosia", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });

            while (0 < stos.Count)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }

        private static void Kolejka()
        {
            Console.WriteLine("Kolejka: ");

            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Marek", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Zosia", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });

            while (0 < kolejka.Count)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
