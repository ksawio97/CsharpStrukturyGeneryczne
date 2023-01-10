using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void DodawaniePoElemencie()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.AddAfter(lista.First, "Ola");

            Assert.AreEqual("Ola", lista.First.Next.Value);
        }

        [TestMethod]
        public void DodawaniePrzedElementem()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.AddBefore(lista.First, "Ola");

            Assert.AreEqual("Ola", lista.First.Value);
        }

        [TestMethod]
        public void UsuwanieOstatniegoElementu()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.RemoveLast();

            Assert.AreEqual("Marcin", lista.Last.Value);
        }

        [TestMethod]
        public void UsuwaniePierwszegoElementu()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.Remove("Marcin");

            Assert.AreEqual("Tomek", lista.First.Value);
        }

        [TestMethod]
        public void ListaZawieraElement()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");

            Assert.IsTrue(lista.Contains("Tomek"));
        }

        [TestMethod]
        public void CzyszczenieListy()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.Clear();

            Assert.AreEqual(0, lista.Count);
        }
    }
}
