using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Model
{
    internal class BinarySearchTree<T> : IEnumerable
        where T : IComparable
    {
        public BinarySearchTreeNode<T> Root { get; private set; }
        public int Count { get; private set; }
        public BinarySearchTree(BinarySearchTreeNode<T> root)
        {
            if (root != null)
                Root = root;
            else throw new ArgumentNullException("Root is null");
        }
        public BinarySearchTree(T data) : this(new BinarySearchTreeNode<T>(data)) { }
        public BinarySearchTree()
        {
            Root = null;
        }
        public BinarySearchTree(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }
        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new BinarySearchTreeNode<T>(data);
                Count++;
            }
            else
            {
                Root.Add(data);
                Count++;
            }
        }
        public List<T> Preorder()
        {
            if (Root == null)
            {
                return new List<T>(0);
            }
            return Root.Preorder();
        }
        public List<T> Postorder()
        {
            if (Root == null)
            {
                return new List<T>(0);
            }
            return Root.Postorder();
        }
        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>(0);
            }
            return Root.Inorder();
        }
        public BinarySearchTree<T> Copy()
        {
            var result = new BinarySearchTree<T>();
            foreach (var item in Preorder())
            {
                result.Add(item);
            }
            return result;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Preorder().GetEnumerator();
        }
    }
}
