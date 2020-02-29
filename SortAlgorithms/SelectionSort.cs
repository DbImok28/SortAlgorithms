using System;
using System.Collections.Generic;
using Algorithms.Model;

namespace Algorithms
{
    public class SelectionSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public SelectionSort(IEnumerable<T> items) : base(items) { }
        public SelectionSort() { }
        public override string ToString()
        {
            return "SelectionSort";
        }
        protected override void Sort()
        {
            int minIndex = 1;
            for (int i = 0; i < Items.Count - 1; i++)                              
            {
                for (int j = i; j < Items.Count; j++)                
                    if (Compare(Items[j], Items[minIndex]) == -1)
                        minIndex = j;
                if (minIndex != i)               
                    Swop(i, minIndex);                
                minIndex = i + 1;
            }
        }
    }
}
