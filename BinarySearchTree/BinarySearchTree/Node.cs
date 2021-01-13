using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node<T> where T : IComparable
    {
        private T data;
        protected int balanceFactor = 0; //added for AVLTree
        public Node<T> Left, Right;
      
        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }
        public T Data
        {
            set { data = value; }
            get { return data; }
        }
        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }
    }

}
