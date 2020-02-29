using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class InsertionSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public InsertionSort(IEnumerable<T> items) : base(items) { }
        public InsertionSort() { }
        public override void Sort()
        {
            SwopCount = ComparisonCount = 0;
            for (int i = 1; i < Items.Count; i++)
            {
                T temp = Items[i];
                int j = i;
                while (j > 0 && Compare(temp,Items[j - 1]) == -1)
                {
                    //SwopCount++;
                    Swop(j, j - 1);
                    //Items[j] = Items[j - 1];
                    j--;
                }
                Items[j] = temp;
            }
        }
        public override string ToString()
        {
            return "InsertionSort";
        }
    }
}
