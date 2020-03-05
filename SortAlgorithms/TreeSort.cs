using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class TreeSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public TreeSortNode<T> Root { get; private set; } = null;
        public int Count { get; private set; } = 0;

        public TreeSort() { }
        public TreeSort(IEnumerable<T> items) : base(items) { }
        private void Add(TreeSortNode<T> node)
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
        private void Add(TreeSortNode<T> node, TreeSortNode<T> newNode)
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
        private List<TreeSortNode<T>> Inorder(TreeSortNode<T> node)
        {
            var list = new List<TreeSortNode<T>>();
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
                Add(new TreeSortNode<T>(Items[i], i));
            }
            var result = Inorder(Root);

            for (int i = 0; i < result.Count; i++)
            {
                Set(i, result[i].Data);
            }
            Root = null;
        }
    }
}