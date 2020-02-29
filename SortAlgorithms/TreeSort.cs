using System;
using System.Collections.Generic;
using Algorithms.Model;

namespace Algorithms
{
    public class TreeSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public TreeSort(IEnumerable<T> items) : base(items) { }
        public TreeSort() { }
        protected override void Sort()
        {         
            Items = new BinarySearchTree<T>(Items).Inorder();
        }
        public override string ToString()
        {
            return "TreeSort";
        }
    }
}