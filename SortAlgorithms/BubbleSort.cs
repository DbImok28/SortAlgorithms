using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class BubbleSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public BubbleSort(IEnumerable<T> items) : base(items) { }
        public BubbleSort() { }
        public override string ToString()
        {
            return "BubbleSort";
        }
        protected override void Sort()
        {      
            for (int j = 0; j < Items.Count; j++)
            {
                //bool IsSwoped = false;
                for (int i = 0; i < Items.Count - j - 1; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];
                    if (Compare(a,b) == 1)
                    {
                        Swop(i, i + 1);
                        //IsSwoped = true;
                    }
                }
                //if (IsSwoped == false)
                //{
                //    return;
                //}
            }           
        }
    }
}
