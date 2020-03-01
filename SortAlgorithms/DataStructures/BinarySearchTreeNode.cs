using System;
using System.Collections.Generic;

namespace Algorithms.Model
{
    public class BinarySearchTreeNode<T>
        where T : IComparable
    {
        public T Data { get; set; }
        public BinarySearchTreeNode<T> Left { get; set; }
        public BinarySearchTreeNode<T> Right { get; set; }
   
        public int Index { get; set; }

        public BinarySearchTreeNode(T data, int index)
        {
            Index = index;
            Data = data;
        }
        public BinarySearchTreeNode(T data, BinarySearchTreeNode<T> left, BinarySearchTreeNode<T> right)
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
