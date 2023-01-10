using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class ListaTests
    {
        [TestMethod]
        public void ListaMozemyDodawacNaKoniec()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.Add(4);

            Assert.AreEqual(4, listaLiczb.Count);
        }

        [TestMethod]
        public void ListaMozemyDodawacNaPozycji()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.Insert(1, 8);

            Assert.AreEqual(8, listaLiczb[1]);
        }

        [TestMethod]
        public void ListaMozemyUsuwacNaPozycji()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.RemoveAt(1);

            Assert.AreEqual(3, listaLiczb[1]);
        }

        [TestMethod]
        public void ListaMozemyUsuwacElement()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.Remove(1);

            Assert.IsTrue(listaLiczb.SequenceEqual(new[] { 2, 3 } ));
        }

        [TestMethod]
        public void ListaMozemyWyszukiwac()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            Assert.AreEqual(2, listaLiczb.IndexOf(3));
        }

        [TestMethod]
        public void ListaCzyJestElement()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            Assert.IsTrue(listaLiczb.Contains(2));
        }

        [TestMethod]
        public void ListaDodajemyNaKoniecZakresLiczb()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            listaLiczb.AddRange(new[] { 4, 5, 6 });
            Assert.AreEqual(6, listaLiczb[5]);
        }
    }
}
