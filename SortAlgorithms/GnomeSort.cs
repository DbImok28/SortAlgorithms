using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class GnomeSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public GnomeSort(IEnumerable<T> items) : base(items) { }
        public GnomeSort() { }
        public override string ToString()
        {
            return "GnomeSort";
        }
        protected override void Sort()
        {
            int i = 0;
            while(i < Items.Count - 1)
            {
                if (i > -1 && Compare(Items[i], Items[i + 1]) == 1)
                {
                    Swop(i, i + 1);
                    i--;
                }
                else i++;
            }
        }
    }
}
