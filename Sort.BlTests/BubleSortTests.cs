using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Bl.Tests
{
    [TestClass()]
    public class BubleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var bubble = new BubleSort<int>();
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