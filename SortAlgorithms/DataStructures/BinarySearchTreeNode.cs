using System;
using System.Collections.Generic;

namespace Algorithms.Model
{
    internal class BinarySearchTreeNode<T> : IComparable<T>
        where T : IComparable
    {
        public T Data { get; private set; }
        public BinarySearchTreeNode<T> Left { get; private set; } = null;
        public BinarySearchTreeNode<T> Right { get; private set; } = null;
        public BinarySearchTreeNode(T data)
        {
            Data = data;
        }
        public BinarySearchTreeNode(T data, BinarySearchTreeNode<T> left, BinarySearchTreeNode<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        public void Add(BinarySearchTreeNode<T> node)
        {
            if (Data.CompareTo(node.Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(node);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(node);
                }
            }
        }

        public List<T> Preorder()
        {
            List<T> items = new List<T>
            {
                Data
            };
            if (Left != null)
            {
                items.AddRange(Left.Preorder());
            }
            if (Right != null)
            {
                items.AddRange(Right.Preorder());
            }
            return items;

        }
        public List<T> Postorder()
        {
            List<T> items = new List<T>();
            if (Left != null)
            {
                items.AddRange(Left.Postorder());
            }
            if (Right != null)
            {
                items.AddRange(Right.Postorder());
            }
            items.Add(Data);
            return items;
        }
        public List<T> Inorder()
        {
            List<T> items = new List<T>();
            if (Right != null)
            {
                items.AddRange(Right.Inorder());
            }
            items.Add(Data);
            if (Left != null)
            {
                items.AddRange(Left.Inorder());
            }
            return items;
        }
        public void Add(T data)
        {
            Add(new BinarySearchTreeNode<T>(data));
        }

        public int CompareTo(object other)
        {
            if (other is BinarySearchTreeNode<T> item)
                return item.Data.CompareTo(this.Data);
            //return (item.Data.Equals(Data) ? 1 : (item.Data.Equals(Data) ? 0 : -1));
            else
                throw new ArgumentException("Item is not compare");
        }
        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
