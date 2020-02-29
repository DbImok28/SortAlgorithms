using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Model
{
    internal class Heap<T> : IEnumerable<T>
        where T : IComparable
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        public event EventHandler<Tuple<T, T>> SwopEvent;

        public Heap()
        {

        }
        public Heap(T data)
        {
            Add(data);
        }
        public Heap(List<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }

        }
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
                return items[0];
            return default(T);
        }
        public void Add(T data)
        {
            if (data == null)
            {
                throw new NullReferenceException("data is null");
            }
            items.Add(data);
            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);
            while (currentIndex > 0 && items[parentIndex].CompareTo(items[currentIndex]) == 1)
            {
                Swop(currentIndex, parentIndex);
                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }
        private void Swop(int currentIndex, int parentIndex)
        {
            SwopEvent?.Invoke(this, new Tuple<T, T>(items[currentIndex], items[parentIndex]));
            var temp = items[currentIndex];
            items[currentIndex] = items[parentIndex];
            items[parentIndex] = temp;
        }
        public T PopMin ()
        {
            var result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort();
            return result;
        }
        private void Sort()
        {
            Sort(0);
        }
        private void Sort(int currentIndex)
        {
            int leftIndex, rightIndex, maxIndex;
            maxIndex = currentIndex;
            while (currentIndex < Count)
            {
                leftIndex = currentIndex * 2 + 1;
                rightIndex = currentIndex * 2 + 2;
                if (leftIndex < Count && items[leftIndex].CompareTo(items[maxIndex]) == -1)
                {
                    maxIndex = leftIndex;
                }
                if (rightIndex < Count && items[rightIndex].CompareTo(items[maxIndex]) == -1)
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
