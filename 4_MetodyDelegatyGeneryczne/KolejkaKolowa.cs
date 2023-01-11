using System;

namespace _4_MetodyDelegatyGeneryczne
{
    public class KolejkaKolowa<T> : DuzaKolejka<T>
    {
        private int _pojemnosc;

        public KolejkaKolowa(int pojemnosc = 5)
        {
            _pojemnosc = pojemnosc;
        }

        public override void Zapisz(T wartosc)
        {
            base.Zapisz(wartosc);

            if (_pojemnosc < kolejka.Count)
            {
                var deleted = kolejka.Dequeue();
                PoUsunieciuElementu(deleted, wartosc);
            }
        }

        private void PoUsunieciuElementu(T deleted, T wartosc)
        {
            if(deleted != null)
            {
                var args = new ElementUsunietyEventArgs<T>(deleted, wartosc);
                elementUsuniety(this, args);
            }
        }

        public override bool JestPelny
        {
            get
            {
                return kolejka.Count == _pojemnosc;
            }
        }

        public event EventHandler<ElementUsunietyEventArgs<T>> elementUsuniety;
    }

    public class ElementUsunietyEventArgs<T> : EventArgs
    {
        public T ElementUsuniety { get; set; }
        public T ElementNowy { get; set; }

        public ElementUsunietyEventArgs(T elementUsuniety, T elementNowy)
        {
            ElementNowy = elementNowy;
            ElementUsuniety = elementUsuniety;
        }
    }
}
