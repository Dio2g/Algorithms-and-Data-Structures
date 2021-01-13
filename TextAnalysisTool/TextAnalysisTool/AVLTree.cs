using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalysisTool
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree) //insert item into AVLtree, ensures tree remains balanced 
        {

            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }

            tree.BalanceFactor = height(tree.Left) - height(tree.Right);

            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }
            if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }

        }

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
            {
                rotateRight(ref tree.Right);
            }

            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Right;

            oldRoot.Right = null;

            tree = newRoot;
            oldRoot.Right = tree.Left;
            tree.Left = oldRoot;

        }
        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)
            {
                rotateLeft(ref tree.Left);
            }

            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Left;

            oldRoot.Left = null;

            tree = newRoot;
            oldRoot.Left = tree.Right;
            tree.Right = oldRoot;

        }

    }

}


