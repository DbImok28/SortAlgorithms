using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Model
{
    public class BinarySearchTree<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public BinarySearchTreeNode<T> Root { get; private set; } = null;
        public int Count { get; private set; } = 0;

        public BinarySearchTree() { }
        public BinarySearchTree(IEnumerable<T> items) : base(items)
        {
            //Items.AddRange(items);
            //var list = items.ToList();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    var item = list[i];
            //    Items.Add(item);

            //    var node = new BinarySearchTreeNode<T>(item, i);
            //    Add(node);
            //}
        }
        //public override void Add(T item)
        //{
        //    Items.Add(item);
        //    //Add(new BinarySearchTreeNode<T>(item, Items.Count));
        //}
        private void Add(BinarySearchTreeNode<T> node)
        {
            if (Root == null)
            {
                Root = node;
                Count++;
            }
            else
            {
                Add(Root, node);
                Count++;
            }
        }
        private void Add(BinarySearchTreeNode<T> node, BinarySearchTreeNode<T> newNode)
        {
            if (Compare(node.Data, newNode.Data) == 1)
            {
                if (node.Left == null)
                {
                    node.Left = newNode;
                }
                else
                {
                    Add(node.Left, newNode);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = newNode;
                }
                else
                {
                    Add(node.Right, newNode);
                }
            }
        }
        private List<BinarySearchTreeNode<T>> Inorder(BinarySearchTreeNode<T> node)
        {
            var list = new List<BinarySearchTreeNode<T>>();
            if (node != null)
            {

                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }
                list.Add(node);
                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }
            return list;
        }

        public override string ToString()
        {
            return "TreeSort";
        }
        protected override void Sort()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Add(new BinarySearchTreeNode<T>(Items[i], i));
            }

            var result = Inorder(Root);
            Items.AddRange(result.Select(i => i.Data));
            for (int i = 0; i < result.Count; i++)
            {
                Swop(i, result.Count + i);
            }
            Items.RemoveRange(result.Count, result.Count);
        }
    }
}
