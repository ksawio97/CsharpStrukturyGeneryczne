using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _1_TypyGeneryczne;

namespace _1_TypyGeneryczneTests
{
    [TestClass]
    public class KolejkaKolowaTests
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var kolejka = new KolejkaKolowa();

            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void KolejkaJestPelnaPoTrzechZapisach()
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);
            kolejka.Zapisz("1.1");
            kolejka.Zapisz(2.3);
            kolejka.Zapisz(3.4);

            Assert.IsTrue(kolejka.JestPelny);
        }
        //FIFO
        [TestMethod]
        public void PierwszyWchodziPierwszyWychodzi()
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);
            double[] wartosci = { 1.1, 2.2, 3.3 };
            
            foreach(var wartosc in wartosci) 
                kolejka.Zapisz(wartosc);


            foreach (var wartosc in wartosci)
                Assert.AreEqual(wartosc, kolejka.Czytaj());

            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void NadipujeGdyJestWiekszaPojemnosc()
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);
            double[] wartosci = { 1.1, 2.2, 3.3, 4.6, 7.2, 2.1 };

            foreach(var wartosc in wartosci)
                kolejka.Zapisz(wartosc);

            Assert.IsTrue(kolejka.JestPelny);

            for(int i = 3; i < wartosci.Length;i++)
                Assert.AreEqual(wartosci[i], kolejka.Czytaj());

            Assert.IsTrue(kolejka.JestPusty);
        }
    }
}
