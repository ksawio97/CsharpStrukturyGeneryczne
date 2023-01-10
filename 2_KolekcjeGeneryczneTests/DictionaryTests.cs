using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void UzywamySlownikaJakoMapy()
        {
            var mapa = new Dictionary<int, string>();

            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            Assert.AreEqual("jeden", mapa[1]);
        }

        [TestMethod]
        public void WyszukiwanieWSlowniku()
        {
            var mapa = new Dictionary<int, string>();

            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            Assert.IsTrue(mapa.ContainsKey(2));
            Assert.IsFalse(mapa.ContainsKey(0));

            Assert.IsTrue(mapa.ContainsValue("dwa"));
        }

        [TestMethod]
        public void UsuwanieZeSlownika()
        {
            var mapa = new Dictionary<int, string>();

            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            mapa.Remove(1);

            Assert.AreEqual(2, mapa.Count);
        }

        [TestMethod]
        public void CzyszczenieSlownika()
        {
            var mapa = new Dictionary<int, string>();

            mapa.Add(1, "jeden");
            mapa.Add(2, "dwa");
            mapa.Add(3, "trzy");

            mapa.Clear();

            Assert.AreEqual(0, mapa.Count);
        }
    }
}
