using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {  //root declared as protected in Parent Class – Binary Tree
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);

            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);

            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);

        }

        public int Height()
        {
            return height(root);
        }

        protected int height(Node<T> root)
        //Return the max level of the tree
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(height(root.Left), height(root.Right));
            }
        }

        public Boolean Contains(T item)
        {
            return contains(root, item);
        }
        private Boolean contains(Node<T> node, T item)
        {
            if (node == null)
            {
                return false;
            }
            if (node.Data.CompareTo(item) > 0)
            {
                return contains(node.Left, item);
            }
            if (node.Data.CompareTo(item) < 0)
            {
                return contains(node.Right, item);
            }
            else
            {
                return true;
            }
        }

        public void removeItem(T item)
        {
            RemoveItem(ref root, item);
        }

        private void RemoveItem(ref Node<T> node, T item) 
        {
            if (node == null)
            {
            }
            else if (item.CompareTo(node.Data) < 0)     
            {
                RemoveItem(ref node.Left, item);
            }
            else if (item.CompareTo(node.Data) > 0)     
            {
                RemoveItem(ref node.Right, item);
            }
            else             
            {
                if (node.Left == null)          
                {
                    node = node.Right;
                }
                else if (node.Right == null)     
                {
                    node = node.Left;
                }
                else
                {                           
                    T newRoot = leastItem(node.Right);
                    node.Data = newRoot;
                    RemoveItem(ref node.Right, newRoot);
                }
            }
        }
        public T leastItem(Node<T> node)
        {
            if (node.Left == null)
                return node.Data;
            else
                return leastItem(node.Left);
        }
    }

}
