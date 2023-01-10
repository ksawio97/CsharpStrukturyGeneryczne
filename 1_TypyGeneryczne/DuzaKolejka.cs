namespace _1_TypyGeneryczne
{
    internal class DuzaKolejka<T>:IKolejka<T>
    {
        private int pojemnosc;

        public DuzaKolejka(int pojemnosc)
        {
            this.pojemnosc = pojemnosc;
        }

        public bool JestPelny => throw new System.NotImplementedException();

        public bool JestPusty => throw new System.NotImplementedException();

        public T Czytaj()
        {
            throw new System.NotImplementedException();
        }

        public void Zapisz(T wartosc)
        {
            throw new System.NotImplementedException();
        }
    }
}