using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using Algorithms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> Item = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Item.Clear();
            FillRandom(ref Item);
        }
        public void FillRandom(ref List<int> item)
        {
            for (int i = 0; i < 1000; i++)
            {
                item.Add(rnd.Next(0, 1000));
            }
        }
        public void SortTest(AlgorithmsBase<int> toSort)
        {
            FillRandom(ref Item);
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
    }
}