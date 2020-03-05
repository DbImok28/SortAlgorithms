using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class MSDRadixSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public MSDRadixSort(IEnumerable<T> items) : base(items) { }
        public MSDRadixSort() { }
        public override string ToString()
        {
            return "MSDRadixSort";
        }

        /// <summary>
        /// uint only!
        /// </summary>
        protected override void Sort()
        {
            int length = 0;
            for (int i = 0; i < Items.Count; i++)
            {
                int max = (int)Math.Ceiling(Math.Log10(Items[i].GetHashCode() + 0.5));
                if (length < max)
                    length = max;
            }
            var result = SubSort(Items, length - 1);
            for (int i = 0; i < result.Count; i++)
            {
                Set(i, result[i]);
            }
        }
        private List<T> SubSort(List<T> collection, int step)
        {
            var result = new List<T>();
            //create groups

            var groups = new List<List<T>>(10);
            for (int i = 0; i < 10; i++)
                groups.Add(new List<T>());

            //sort

            for (int i = 0; i < collection.Count; i++)
                groups[(int)(collection[i].GetHashCode() % Math.Pow(10, step + 1) / Math.Pow(10, step))].Add(collection[i]);

            for (int i = 0; i < groups.Count; i++)
            {
                if (groups[i].Count > 1 && step > 0)
                    result.AddRange(SubSort(groups[i], step - 1));
                else
                    result.AddRange(groups[i]);
            }
            return result;
        }
    }
}

