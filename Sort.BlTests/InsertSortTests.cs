using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Sort.Bl.Tests
{
    [TestClass()]
    public class InsertSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var cocktailSort = new InsertionSort<int>();
            var rnd = new Random();
            var items = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            cocktailSort.Items.AddRange(items);
            items.Sort();
            cocktailSort.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], cocktailSort.Items[i]);
            }
        }
    }
}