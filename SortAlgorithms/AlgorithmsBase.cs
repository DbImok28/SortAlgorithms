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
        public AlgorithmsBase(List<T> items)
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
                T temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
                SwopCount++;
            }
        }
        public virtual void Sort()
        {
            throw new NotImplementedException();
        }
        public TimeSpan TimeToSort()
        {
            var sw = new Stopwatch();
            sw.Start();
            Sort();
            sw.Stop();
            return sw.Elapsed;
        }
        public override string ToString()
        {
            return "None";
        }
    }
}
