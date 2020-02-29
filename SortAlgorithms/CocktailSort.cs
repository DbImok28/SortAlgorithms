using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class CocktailSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public CocktailSort(IEnumerable<T> items) : base(items) { }
        public CocktailSort() { }
        public override string ToString()
        {
            return "CocktailSort";
        }
        protected override void Sort()
        {
            int left = 0;
            int right = Items.Count - 1;
            while (right > left)
            {
                bool IsSwoped = false;
                for (int i = left; i < right; i++)
                {
                    if (Compare(Items[i], Items[i + 1]) == 1)
                    {
                        Swop(i, i + 1);
                        IsSwoped = true;
                    }
                }
                if (IsSwoped == false)
                {
                    return;
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (Compare(Items[i], Items[i - 1]) == -1)
                    {
                        Swop(i, i - 1);
                        IsSwoped = true;
                    }
                }
                if (IsSwoped == false)
                {
                    return;
                }
                left++;
            }
        }
    }
}
