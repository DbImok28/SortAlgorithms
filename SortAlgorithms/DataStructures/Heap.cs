using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Model
{
    internal class Heap<T> : AlgorithmsBase<T>, IEnumerable<T>
        where T : IComparable
    {      
        public int Count => Items.Count;
        public Heap() { }
        public Heap(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public T GetMin()
        {
            if (Count > 0)
                return Items[0];
            return default(T);
        }
        public void Add(T data)
        {
            if (data == null)
            {
                throw new NullReferenceException("data is null");
            }
            Items.Add(data);
            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);
            while (currentIndex > 0 && Compare(Items[parentIndex], Items[currentIndex]) == 1)
            {
                Swop(currentIndex, parentIndex);
                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }
        public T PopMin()
        {
            var result = Items[0];
            Items[0] = Items[Count - 1];
            Items.RemoveAt(Count - 1);
            Sort();
            return result;
        }
        private void Sort(int currentIndex = 0)
        {
            int leftIndex, rightIndex, maxIndex;
            maxIndex = currentIndex;
            while (currentIndex < Count)
            {
                leftIndex = currentIndex * 2 + 1;
                rightIndex = currentIndex * 2 + 2;
                if (leftIndex < Count && Compare(Items[leftIndex], Items[maxIndex]) == -1)
                {
                    maxIndex = leftIndex;
                }
                if (rightIndex < Count && Compare(Items[rightIndex], Items[maxIndex]) == -1)
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
        public int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        public IEnumerator GetEnumerator()
        {
            var tempHeap = this;
            while (tempHeap.Count > 0)
            {
                yield return tempHeap.PopMin();
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var tempHeap = this;
            while (tempHeap.Count > 0)
            {
                yield return tempHeap.PopMin();
            }
        }
        public List<T> ToList()
        {
            var result = new List<T>();
            var tempHeap = this;
            while (tempHeap.Count > 0)
            {
                result.Add(tempHeap.PopMin());
            }
            return result;
        }
    }
}
