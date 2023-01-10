using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_KolekcjeGeneryczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kolejka();
            //Console.WriteLine();
            //Stos();
            //Console.WriteLine();
            //HashSet();
            //Console.WriteLine();
            //LinkedList();
            //Console.WriteLine();
            //LinkedList2();
            //Dictionary();
            //Console.WriteLine();
            //SortedDictionary();
            //Console.WriteLine();
        }

        private static void SortedDictionary()
        {
            var pracownicy = new SortedDictionary<string, List<Pracownik>>();

            Pracownik createNewPracownik(string imie, string nazwisko) => new Pracownik { Imie = imie, Nazwisko = nazwisko };
            pracownicy.Add("Sprzedaz", new List<Pracownik>()
            {
                createNewPracownik("Jan", "Kowal"),
                createNewPracownik("Tomek", "Nowak"),
                createNewPracownik("Marcin", "Biden"),
            });

            pracownicy.Add("Informatyka", new List<Pracownik>()
            {
                createNewPracownik("Marcin", "Kowal"),
                createNewPracownik("Tomek", "Wrobel")
            });

            pracownicy.Add("Ksiegowosc", new List<Pracownik>()
            {
                createNewPracownik("Joanna", "Zloto"),
                createNewPracownik("Ania", "Niszewicz")
            });

            foreach (var item in pracownicy)
            {
                Console.WriteLine($"Ilosc pracownikow w dziale {item.Key} wynosi {item.Value.Count}");
                foreach (var pracownik in item.Value)
                    Console.WriteLine("\t" + pracownik.Imie + " : " + pracownik.Nazwisko);
            }
        }

        private static void Dictionary()
        {
            var pracownicy = new Dictionary<string, List<Pracownik>>();

            Pracownik createNewPracownik(string nazwisko) => new Pracownik { Nazwisko = nazwisko };
            pracownicy.Add("Ksiegowosc", new List<Pracownik>() {
                createNewPracownik("Nowak"),
                createNewPracownik("Kowal"),
                createNewPracownik("Kaczor")
            });

            pracownicy["Ksiegowosc"].Add(createNewPracownik("Nowak"));

            pracownicy.Add("Informatyka", new List<Pracownik>() {
                createNewPracownik("Kowalski"),
                createNewPracownik("Bogacki")
            });

            foreach (var item in pracownicy)
            {
                Console.WriteLine($"Dział : {item.Key}");
                foreach (var pracownik in item.Value)
                    Console.WriteLine("\t" + pracownik.Nazwisko);
            }

            Console.WriteLine($"Dział : Ksiegowosc");
            foreach (var pracownik in pracownicy["Ksiegowosc"])
                Console.WriteLine("\t" + pracownik.Nazwisko);
        }

        private static void LinkedList2()
        {
            Console.WriteLine("LinkedList2");

            LinkedList<int> lista = new LinkedList<int>();
            for (int i = 4; i <= 7; i++)
                lista.AddFirst(i);

            var firstElement = lista.First;
            var lastElement = lista.Last;

            lista.AddAfter(firstElement, 10);
            lista.AddBefore(firstElement, 20);

            var wezel = lista.First;

            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void LinkedList()
        {
            Console.WriteLine("LinkedList");

            LinkedList<int> lista = new LinkedList<int>();
            for (int i = 4; i <= 7; i++)
                lista.AddFirst(i);
            lista.AddLast(1);
            lista.AddLast(2);
            foreach (int num in lista)
                Console.WriteLine(num);
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
