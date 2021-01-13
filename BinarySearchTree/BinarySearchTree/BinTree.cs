using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BinTree()
        {
            root = null;
        }

        public BinTree(Node<T> node)
        {
            root = node;
        }

        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                inOrder(tree.Right, ref buffer);
            }
        }

        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }

        private void preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + ",";
                preOrder(tree.Left, ref buffer);
                preOrder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }
        }

        public void Copy(BinTree<T> tree2)
        {
            copy(root, ref tree2.root);
        }

        private void copy(Node<T> tree, ref Node<T> tree2)
        {
            if (tree != null)
            {
                tree2 = new Node<T>(tree.Data);
                copy(tree.Left, ref tree2.Left);
                copy(tree.Right, ref tree2.Right);
            }
        }

        public void Count(ref int counter)
        {
            count(root, ref counter);
        }

        private void count(Node<T> tree, ref int counter)
        {
            if (tree != null)
            {
                count(tree.Left, ref counter);
                counter += 1;
                count(tree.Right, ref counter);
            }
        }
    }

}
