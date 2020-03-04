using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class RadixSort : AlgorithmsBase<uint>
        //where T : IComparable
    {
        public RadixSort(IEnumerable<uint> items) : base(items) { }
        public RadixSort() { }
        public override string ToString()
        {
            return "RadixSort";
        }
        private uint GetMaxNumberLength()
        {
            uint length = 0;
            foreach (var item in Items)
            {
                uint max = (uint)Math.Ceiling(Math.Log10(item + 0.5));
                if (length < max)
                {
                    length = max;
                }
            }
            return length;
        }
        /// <summary>
        /// uint only!
        /// </summary>
        protected override void Sort()
        {
            //create groups
            var groups = new List<List<uint>>();
            for (int i = 0; i < 10; i++)            
                groups.Add(new List<uint>());
            
            //GetMaxNumberLength
            uint length = 0;
            for (int i = 0; i < Items.Count; i++)
            {
                uint max = (uint)Math.Ceiling(Math.Log10(Items[i] + 0.5));
                if (length < max)
                    length = max;
            }

            //sort
            for (int step = 0; step < length; step++)
            {              
                for (int i = 0; i < Items.Count; i++)               
                    groups[(int)(Items[i] % Math.Pow(10, step + 1) / Math.Pow(10, step))].Add(Items[i]);
                
                Items.Clear();

                for (int i = 0; i < groups.Count; i++)               
                    for (int j = 0; j < groups[i].Count; j++)                   
                        Items.Add(groups[i][j]);

                for (int i = 0; i < groups.Count; i++)
                    groups[i].Clear();               
            }
        }
    }
}

