using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class TreeSortNode<T>
        where T : IComparable
    {
        public T Data { get; set; }
        public TreeSortNode<T> Left { get; set; }
        public TreeSortNode<T> Right { get; set; }
   
        public int Index { get; set; }

        public TreeSortNode(T data, int index)
        {
            Index = index;
            Data = data;
        }
        public TreeSortNode(T data, TreeSortNode<T> left, TreeSortNode<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
      
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
