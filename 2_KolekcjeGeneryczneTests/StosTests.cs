using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class StosTests
    {
        private Stack<int> StackGenerate(int quantity = 5)
        {
            Stack<int> kol = new Stack<int>();
            for (int i = 1; i <= quantity; i++)
                kol.Push(i);

            return kol;
        }


        [TestMethod]
        public void UzyciePeek()
        {
            var kolejka = StackGenerate();

            Assert.AreEqual(5, kolejka.Peek());
        }


        [TestMethod]
        public void UzycieContains()
        {
            var kolejka = StackGenerate();

            Assert.IsTrue(kolejka.Contains(2));
        }

        [TestMethod]
        public void UzycieToArray()
        {
            var kolejka = StackGenerate();

            int[] tablica = kolejka.ToArray();
            kolejka.Pop();

            Assert.AreEqual(5, tablica[0]);
            Assert.AreEqual(4, kolejka.Count);
        }

        [TestMethod]
        public void UzycieClear()
        {
            var kolejka = StackGenerate();

            kolejka.Clear();

            Assert.AreEqual(kolejka.Count, 0);
        }
    }
}
