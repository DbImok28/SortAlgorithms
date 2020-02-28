using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
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
            for (int i = 0; i < 2000; i++)
            {
                item.Add(rnd.Next(0, 1000));
            }
        }
        public void SortTest(AlgorithmsBase<int> toSort)
        {
            FillRandom(ref Item);
            toSort.Items.AddRange(Item);
            Item.Sort();
            toSort.Sort();
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
    }
}