using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Sort.Bl.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        private void AddItems(List<int> items)
        {
            for (int i = 0; i < 500; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
        }
        [TestMethod()]
        public void BubleSortTest()
        {
            var bubble = new BubleSort<int>();
            var items = new List<int>();
            AddItems(items);
            bubble.Items.AddRange(items);
            items.Sort();
            bubble.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], bubble.Items[i]);
            }
        }
        [TestMethod()]
        public void QuickSortTest()
        {
            var QuickSort = new QuickSort<int>();
            var items = new List<int>();
            AddItems(items);
            QuickSort.Items.AddRange(items);
            items.Sort();
            QuickSort.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], QuickSort.Items[i]);
            }
        }
        [TestMethod()]
        public void MergeSortTest()
        {
            var MergeSort = new MergeSort<int>();
            var items = new List<int>();
            AddItems(items);
            MergeSort.Items.AddRange(items);
            items.Sort();
            MergeSort.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], MergeSort.Items[i]);
            }
        }
        //[TestMethod()]
        public void RadixSortTest()
        {
            var radixSort = new RadixSort<int>();
            var items = new List<int>();
            AddItems(items);
            radixSort.Items.AddRange(items);
            items.Sort();
            radixSort.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], radixSort.Items[i]);
            }
        }
        [TestMethod()]
        public void ShellSortTest()
        {
            var Shell = new ShellSort<int>();
            var items = new List<int>();
            AddItems(items);
            Shell.Items.AddRange(items);
            items.Sort();
            Shell.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], Shell.Items[i]);
            }
        }
        [TestMethod()]
        public void SelectionSortTest()
        {
            var SelectionSort = new SelectionSort<int>();
            var items = new List<int>();
            AddItems(items);
            SelectionSort.Items.AddRange(items);
            items.Sort();
            SelectionSort.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], SelectionSort.Items[i]);
            }
        }
        [TestMethod()]
        public void InsertSortTest()
        {
            var InsertionSort = new InsertionSort<int>();
            var items = new List<int>();
            AddItems(items);
            InsertionSort.Items.AddRange(items);
            items.Sort();
            InsertionSort.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], InsertionSort.Items[i]);
            }
        }
        [TestMethod()]
        public void CocktailSortTest()
        {
            var cocktailSort = new CocktailSort<int>();
            var items = new List<int>();
            AddItems(items);
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