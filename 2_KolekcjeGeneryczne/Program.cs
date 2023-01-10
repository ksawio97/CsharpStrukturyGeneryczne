﻿using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolejka: ");

            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Marek", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Zosia", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });

            while(0 < kolejka.Count)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            Console.WriteLine("\nStos:");

            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Marek", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Zosia", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });

            while(0 < stos.Count)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
