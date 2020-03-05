using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class MergeSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public MergeSort() { }
        public MergeSort(IEnumerable<T> items) : base(items) { }
        public override string ToString()
        {
            return "MergeSort";
        }
        protected override void Sort()
        {
            Items = SubSort(Items);
        }
        public List<T> SubSort(List<T> items)
        {
            if (items.Count < 2)           
                return items;
            
            var subCount = items.Count / 2;
            return Merge(SubSort(items.Take(subCount).ToList()),
                         SubSort(items.Skip(subCount).ToList()));
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            var result = new List<T>();
            int leftIndex = 0;
            int rightIndex = 0;
            for (int i = 0; i < left.Count + right.Count; i++)
            {
                if (leftIndex < left.Count && rightIndex < right.Count)
                {
                    if (Compare(left[leftIndex], right[rightIndex]) == -1)
                        result.Add(left[leftIndex++]);
                    else
                        result.Add(right[rightIndex++]);
                }
                else
                {
                    if (rightIndex < right.Count)
                        result.Add(right[rightIndex++]);
                    else
                        result.Add(left[leftIndex++]);
                }
            }

            return result;
        }
    }
}
