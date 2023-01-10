using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    public class DziałyKolekcja : SortedDictionary<string, SortedSet<Pracownik>>
    {
        public DziałyKolekcja Add(string nazwaDzialu, Pracownik pracownik)
        {
            if (!ContainsKey(nazwaDzialu))
                Add(nazwaDzialu, new SortedSet<Pracownik>(new PracownikComparer()));
            this[nazwaDzialu].Add(pracownik);
            return this;
        }
    }
}
