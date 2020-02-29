using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    public class AlgorithmsBase<T>
        where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();
        public int SwopCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set; } = 0;
        public event EventHandler<Tuple<T, T>> CompareEvent;
        public event EventHandler<Tuple<T, T>> SwopEvent;
        public AlgorithmsBase(IEnumerable<T> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            Items.AddRange(items);
        }
        public AlgorithmsBase()
        {

        }       
        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                SwopEvent?.Invoke(this,new Tuple<T, T>(Items[positionA], Items[positionB]));
                SwopCount++;
                T temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }
        protected virtual void Sort()
        {
            throw new NotImplementedException();
        }        
        public TimeSpan TimeToSort()
        {
            SwopCount = ComparisonCount = 0;
            var sw = new Stopwatch();
            sw.Start();
            Sort();
            sw.Stop();
            return sw.Elapsed;
        }
        protected int Compare(T a, T b)
        {
            ComparisonCount++;
            CompareEvent?.Invoke(this, new Tuple<T, T>(a, b));
            return a.CompareTo(b);
        }
        public override string ToString()
        {
            return "None";
        }

    }
}
