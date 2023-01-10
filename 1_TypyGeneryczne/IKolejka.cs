namespace _1_TypyGeneryczne
{
    public interface IKolejka<T>
    {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Czytaj();
        void Zapisz(T wartosc);
    }
}