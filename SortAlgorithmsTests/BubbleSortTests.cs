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
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var bubble = new BubbleSort<int>();
            var rnd = new Random();
            List<int> items = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            bubble.Items.AddRange(items);
            items.Sort();
            bubble.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(bubble.Items[i], items[i]);
            }
        }
    }
}