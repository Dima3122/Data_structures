using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Sort.Bl.Tests
{
    [TestClass()]
    public class SelectionSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var bubble = new SelectionSort<int>();
            var rnd = new Random();
            var items = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            bubble.Items.AddRange(items);
            items.Sort();
            bubble.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], bubble.Items[i]);
            }
        }
    }
}