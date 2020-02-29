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
        public override string ToString()
        {
            return "HeapSort";
        }
        protected override void Sort()
        {
            var heap = new Heap<T>(Items);
            Items = heap.ToList();
        }
    }
}

