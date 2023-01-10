using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class KolejkaTests
    {
        private Queue<int> QueGenerate(int quantity = 5)
        {
            Queue<int> kol = new Queue<int>();
            for(int i = 1; i <= quantity; i++)
                kol.Enqueue(i);

            return kol;
        }


        [TestMethod]
        public void UzyciePeek()
        {
            var kolejka = QueGenerate();

            Assert.AreEqual(1, kolejka.Peek());
        }


        [TestMethod]
        public void UzycieContains()
        {
            var kolejka = QueGenerate();

            Assert.IsTrue(kolejka.Contains(2));
        }

        [TestMethod]
        public void UzycieToArray()
        {
            var kolejka = QueGenerate();

            int[] tablica = kolejka.ToArray();
            kolejka.Dequeue();

            Assert.AreEqual(1, tablica[0]);
            Assert.AreEqual(4, kolejka.Count);
        }

        [TestMethod]
        public void UzycieClear()
        {
            var kolejka = QueGenerate();

            kolejka.Clear();

            Assert.AreEqual(kolejka.Count, 0);
        }
    }
}
