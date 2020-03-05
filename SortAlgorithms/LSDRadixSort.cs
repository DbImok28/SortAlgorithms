using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class LSDRadixSort<T> : AlgorithmsBase<T>
        where T: IComparable
    {
        public LSDRadixSort(IEnumerable<T> items) : base(items) { }
        public LSDRadixSort() { }
        public override string ToString()
        {
            return "LSDRadixSort";
        }
        
        /// <summary>
        /// positive int only!
        /// </summary>
        protected override void Sort()
        {
            //if (!(Items is List<int>))
            //    throw new ArgumentException("data type is not int or positive int");
            //create groups
            var groups = new List<List<T>>(10);
            for (int i = 0; i < 10; i++)            
                groups.Add(new List<T>());
            
            //GetMaxNumberLength
            int length = 0;
            for (int i = 0; i < Items.Count; i++)
            {
                int max = (int)Math.Ceiling(Math.Log10(Items[i].GetHashCode() + 0.5));
                if (length < max)
                    length = max;
            }

            //sort
            for (int step = 0; step < length; step++)
            {
                for (int i = 0; i < Items.Count; i++)
                    groups[(int)(Items[i].GetHashCode() % Math.Pow(10, step + 1) / Math.Pow(10, step))].Add(Items[i]);
                
                //Items.Clear();

                var f = 0;
                for (int i = 0; i < groups.Count; i++)
                    for (int j = 0; j < groups[i].Count; j++)
                    {
                        //Items.Add(groups[i][j]);
                        Set(f, groups[i][j]);
                        f++;
                    }

                for (int i = 0; i < groups.Count; i++)
                    groups[i].Clear();               
            }
        }
    }
}

