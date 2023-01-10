using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class HashSetTests
    {
        private HashSet<int> HashSetGenerate(int start = 1, int quantity = 3)
        {
            HashSet<int> hashSet = new HashSet<int>();
            for (int i = start; i < start + quantity; i++)
                hashSet.Add(i);

            return hashSet;
        }


        [TestMethod]
        public void IntersectSet()
        {
            var set1 = HashSetGenerate();
            var set2 = HashSetGenerate(2);

            set1.IntersectWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
        }

        [TestMethod]
        public void UnionSets()
        {
            var set1 = HashSetGenerate();
            var set2 = HashSetGenerate(2);

            set1.UnionWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void SymmetricExceptSets()
        {
            var set1 = HashSetGenerate();
            var set2 = HashSetGenerate(2);

            set1.SymmetricExceptWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));
        }

        [TestMethod]
        public void RemoveSet()
        {
            var set1 = HashSetGenerate();

            set1.Remove(1);

            Assert.AreEqual(2, set1.Count);
        }

        [TestMethod]
        public void RemoveWhereSet()
        {
            var set1 = HashSetGenerate();

            set1.RemoveWhere(x => 1 < x);

            Assert.AreEqual(1, set1.Count);
        }

        [TestMethod]
        public void ContainsSet()
        {
            var set1 = HashSetGenerate();

            Assert.IsTrue(set1.Contains(3));
        }
    }
}
