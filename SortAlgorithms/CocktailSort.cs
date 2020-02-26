using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class CocktailSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public CocktailSort(List<T> items) : base(items)
        {
        }
        public CocktailSort()
        {
        }
        public override void Sort()
        {
            SwopCount = ComparisonCount = 0;
            int left = 0;
            int right = Items.Count - 1;
            while (right > left)
            {               
                bool IsSwoped = false;
                for (int i = left; i < right; i++)
                {
                    ComparisonCount++;
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
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
                    ComparisonCount++;
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
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
        public override string ToString()
        {
            return "CocktailSort";
        }
    }
}
