using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class MSDRadixSort : AlgorithmsBase<uint>
    {
        public MSDRadixSort(IEnumerable<uint> items) : base(items) { }
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
                int max = (int)Math.Ceiling(Math.Log10(Items[i] + 0.5));
                if (length < max)
                    length = max;
            }
            Items = SubSort(Items,length - 1);
        }
        private List<uint> SubSort(List<uint> collection, int step)
        {
            var result = new List<uint>();
            //create groups

            var groups = new List<List<uint>>();
            for (uint i = 0; i < 10; i++)
                groups.Add(new List<uint>());

            //sort

            for (int i = 0; i < collection.Count; i++)
                groups[(int)(collection[i] % Math.Pow(10, step + 1) / Math.Pow(10, step))].Add(collection[i]);

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

