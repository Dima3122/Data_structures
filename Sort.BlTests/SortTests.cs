using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Sort.Bl.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        private void AddItems()
        {
            Items.Clear();
            for (int i = 0; i < 500; i++)
            {
                Items.Add(rnd.Next(0, 100));
            }
        }
        [TestMethod()]
        public void BubleSortTest()
        {
            var bubble = new BubleSort<int>();
            AddItems();
            bubble.Items.AddRange(Items);
            Items.Sort();
            bubble.Sort();
            Thread.Sleep(100);
            for (int i = 0; i < bubble.Items.Count; i++)
            {
                Assert.AreEqual(bubble.Items[i], Items[i]);
            }
        }
        [TestMethod()]
        public void QuickSortTest()
        {
            var QuickSort = new QuickSort<int>();
            AddItems();
            QuickSort.Items.AddRange(Items);
            Items.Sort();
            QuickSort.Sort();
            Thread.Sleep(100);
            for (int i = 0; i < QuickSort.Items.Count; i++)
            {
                Assert.AreEqual(QuickSort.Items[i], Items[i]);
            }
        }
        [TestMethod()]
        public void MergeSortTest()
        {
            var MergeSort = new MergeSort<int>();
            AddItems();
            MergeSort.Items.AddRange(Items);
            Items.Sort();
            MergeSort.Sort();
            Thread.Sleep(100);
            for (int i = 0; i < MergeSort.Items.Count; i++)
            {
                Assert.AreEqual(MergeSort.Items[i], Items[i]);
            }
        }
        /*[TestMethod()]
        public void RadixSortTest()
        {
            var radixSort = new RadixSort<int>();
            AddItems();
            radixSort.Items.AddRange(Items);
            Items.Sort();
            radixSort.Sort();
            Thread.Sleep(100);
            for (int i = 0; i < radixSort.Items.Count; i++)
            {
                Assert.AreEqual(radixSort.Items[i], Items[i]);
            }
        }*/
        [TestMethod()]
        public void ShellSortTest()
        {
            var Shell = new ShellSort<int>();
            AddItems();
            Shell.Items.AddRange(Items);
            Items.Sort();
            Shell.Sort();
            Thread.Sleep(100);
            for (int i = 0; i < Shell.Items.Count; i++)
            {
                Assert.AreEqual(Shell.Items[i], Items[i]);
            }
        }
        [TestMethod()]
        public void SelectionSortTest()
        {
            var SelectionSort = new SelectionSort<int>();
            AddItems();
            SelectionSort.Items.AddRange(Items);
            Items.Sort();
            SelectionSort.Sort();
            Thread.Sleep(100);
            for (int i = 0; i < SelectionSort.Items.Count; i++)
            {
                Assert.AreEqual(SelectionSort.Items[i], Items[i]);
            }
        }
        [TestMethod()]
        public void InsertSortTest()
        {
            var InsertionSort = new InsertionSort<int>();
            AddItems();
            InsertionSort.Items.AddRange(Items);
            Items.Sort();
            InsertionSort.Sort();
            Thread.Sleep(100);
            for (int i = 0; i < InsertionSort.Items.Count; i++)
            {
                Assert.AreEqual(InsertionSort.Items[i], Items[i]);
            }
        }
        [TestMethod()]
        public void CocktailSortTest()
        {
            var cocktailSort = new CocktailSort<int>();
            AddItems();
            cocktailSort.Items.AddRange(Items);
            Items.Sort();
            cocktailSort.Sort();
            Thread.Sleep(100);
            for (int i = 0; i < cocktailSort.Items.Count; i++)
            {
                Assert.AreEqual(cocktailSort.Items[i], Items[i]);
            }
        }
    }
}