using BinarySearchTree.BinarySearchTree;
using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string buffer = "";
            int counter = 0;
            BSTree<int> myTree1 = new BSTree<int>();
            AVLTree<int> myTree2 = new AVLTree<int>();

            myTree1.InsertItem(25);
            myTree1.InsertItem(15);
            myTree1.InsertItem(10);
            myTree1.InsertItem(20);
            myTree1.InsertItem(23);
            myTree1.InsertItem(17);
            myTree1.InOrder(ref buffer);
            Console.WriteLine(buffer);
            myTree1.Count(ref counter);
            Console.WriteLine(counter);
           // Console.WriteLine(myTree1.Height());
            Console.WriteLine(myTree1.Contains(7));

            buffer = "";
           myTree1.removeItem(25);

            myTree1.InOrder(ref buffer);
            Console.WriteLine(buffer);
            Console.WriteLine("Height: ");
            Console.WriteLine(myTree1.Height());

            myTree2.InsertItem(25);
            myTree2.InsertItem(15);
            myTree2.InsertItem(10);
            myTree2.InsertItem(20);
            myTree2.InsertItem(23);
            myTree2.InsertItem(17);
            buffer = "";
            myTree2.InOrder(ref buffer);
            Console.WriteLine(buffer);
            myTree2.Count(ref counter);
            Console.WriteLine(counter);
            //Console.WriteLine(myTree2.Height());
            Console.WriteLine(myTree2.Contains(7));

            buffer = "";
           // myTree2.removeItem(10);

            myTree2.InOrder(ref buffer);
            Console.WriteLine(buffer); ;
            Console.WriteLine("Height: ");
            Console.WriteLine(myTree2.Height());
            


            Console.ReadLine();

        }
    }
}
