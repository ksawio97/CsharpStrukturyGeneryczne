using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _4_MetodyDelegatyGeneryczne
{
    public static class KolejkaExtensions
    {
        public static IEnumerable<Twyjscie> ElementJako<T, Twyjscie>(this IKolejka<T> kolejka)
        {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));

            foreach (var item in kolejka)
            {
                Twyjscie wynik = (Twyjscie)konwerter.ConvertTo(item, typeof(Twyjscie));
                yield return wynik;
            }
        }

        public static void Drukuj<T>(this IKolejka<T> kolejka)
        {
            foreach(var item in kolejka)
                Console.WriteLine(item);
        }
    }
}
