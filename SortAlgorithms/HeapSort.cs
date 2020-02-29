using Algorithms.Model;
using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class HeapSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public HeapSort(IEnumerable<T> items) : base(items) { }
        public HeapSort() { }
        protected override void Sort()
        {
            Items = new Heap<T>(Items).ToList();
        }
        public override string ToString()
        {
            return "HeapSort";
        }
    }
}

