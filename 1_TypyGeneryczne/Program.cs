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
            var kolejka = new KolejkaKolowa(pojemnosc: 3);

            while(true)
            {
                var wartoscWejsciowa = Console.ReadLine();

                var wartosc = 0.0;
                if(double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
            kolejka.Zapisz("Marcepan");
            var suma = 0.0;
            Console.WriteLine("W naszej kolejce jest: ");
            while (!kolejka.JestPusty)
            {
                var wartosc = kolejka.Czytaj();
                if(wartosc is double) 
                    suma += (double)wartosc;
            }
            Console.WriteLine($"Suma: {suma}");
        }
    }
}
