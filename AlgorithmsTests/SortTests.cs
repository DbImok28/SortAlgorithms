using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System;
using System.Collections.Generic;

namespace SortTests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        const int ITEMS_COUNT = 1000;

        List<int> Item = new List<int>();
        [TestInitialize]
        public void Init()
        {
            Item.Clear();
            FillRandom(ref Item);
        }       
        public void FillRandom(ref List<int> item)
        {
            for (int i = 0; i < ITEMS_COUNT; i++)
            {
                item.Add(rnd.Next(0, ITEMS_COUNT));
            }
        }
        public void SortTest(AlgorithmsBase<int> toSort)
        {
            //FillRandom(ref Item);
            toSort.AddRange(Item);
            Item.Sort();
            toSort.TimeToSort();
            for (int i = 0; i < Item.Count; i++)
            {
                Assert.AreEqual(toSort.Items[i], Item[i]);
            }
        }
        [TestMethod()]
        public void BubbleSortTest()
        {
            SortTest(new BubbleSort<int>());
        }
        [TestMethod()]
        public void CocktailSortTest()
        {
            SortTest(new CocktailSort<int>());
        }
        [TestMethod()]
        public void InsertionSortTest()
        {
            SortTest(new InsertionSort<int>());
        }
        [TestMethod()]
        public void ShellSortTest()
        {
            SortTest(new ShellSort<int>());
        }
        [TestMethod()]
        public void TreeSortTest()
        {
            SortTest(new TreeSort<int>());
        }
        [TestMethod()]
        public void HeapSortTest()
        {
            SortTest(new HeapSort<int>());
        }
        [TestMethod()]
        public void SelectionSortTest()
        {
            SortTest(new SelectionSort<int>());
        }
        [TestMethod()]
        public void GnomeSortTest()
        {
            SortTest(new GnomeSort<int>());
        }
        [TestMethod()]
        public void LSDRadixSortTest()
        {
            SortTest(new LSDRadixSort<int>());
        }
        [TestMethod()]
        public void MSDRadixSortTest()
        {
            SortTest(new MSDRadixSort<int>());
        }
        [TestMethod()]
        public void MergeSortTest()
        {
            SortTest(new MergeSort<int>());
        }
    }
}