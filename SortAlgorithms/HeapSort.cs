using Algorithms.Model;
using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class HeapSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public HeapSort() { }
        public HeapSort(IEnumerable<T> items) : base(items) { }

        private void Balance(int currentIndex, int maxCount)
        {
            int leftIndex, rightIndex, maxIndex;
            maxIndex = currentIndex;
            while (currentIndex < maxCount)
            {
                leftIndex = currentIndex * 2 + 1;
                rightIndex = currentIndex * 2 + 2;
                if (leftIndex < maxCount && Compare(Items[leftIndex], Items[maxIndex]) == 1)
                {
                    maxIndex = leftIndex;
                }
                if (rightIndex < maxCount && Compare(Items[rightIndex], Items[maxIndex]) == 1)
                {
                    maxIndex = rightIndex;
                }
                if (maxIndex == currentIndex)
                {
                    break;
                }
                Swop(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }
        }
        public void MakeHeap()
        {
            for (int i = Items.Count; i >= 0; i--)
            {
                Balance(i, Items.Count);
            }
        }

        public override string ToString()
        {
            return "HeapSort";
        }
        protected override void Sort()
        {
            MakeHeap();
            for (int i = Items.Count - 1; i >= 0; i--)
            {
                Swop(0, i);
                Balance(0, i);
            }
        }
    }
}

