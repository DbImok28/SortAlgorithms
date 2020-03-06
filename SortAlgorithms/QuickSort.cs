using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class QuickSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public QuickSort(IEnumerable<T> items) : base(items) { }
        public QuickSort() { }
        public override string ToString()
        {
            return "QuickSort";
        }
        protected override void Sort()
        {
            Sort(0, Items.Count - 1);
        }
        private void Sort(int left, int right)
        {
            if (left >= right)
                return;
            int pivot = SubSort(left, right);
            Sort(left, pivot - 1);
            Sort(pivot + 1, right);
        }
        private int SubSort(int left, int right)
        {
            int minIndex = left;
            for (int i = left; i < right + 1; i++)
            {
                if (Compare(Items[i], Items[right]) == -1)
                {
                    Swop(minIndex, i);
                    minIndex++;
                }
            }
            Swop(minIndex, right);
            return minIndex;
        }

    }
}

