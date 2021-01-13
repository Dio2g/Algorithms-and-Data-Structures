using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalysisTool;
using NUnit.Framework;

namespace treetest
{
    [TestFixture] 
    class TreeTest
    {
        private AVLTree<Word> avltree, avltreeCopy, removedWordTree;
        private Word word1, word2, word3, word4, word5, word6;
        private LinkedList<Location> list1, list2, list3, list4, list5, list6;
        private Location loc1, loc2, loc3, loc4, loc5, loc6;

        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            loc1 = new Location(1, 1);
            loc2 = new Location(1, 2);
            loc3 = new Location(2, 1);
            loc4 = new Location(2, 2);
            loc5 = new Location(2, 3);
            loc6 = new Location(2, 4);
            list1 = new LinkedList<Location>();
            list2 = new LinkedList<Location>();
            list3 = new LinkedList<Location>();
            list4 = new LinkedList<Location>();
            list5 = new LinkedList<Location>();
            list6 = new LinkedList<Location>();
            list1.AddLast(loc1);
            list2.AddLast(loc2);
            list3.AddLast(loc3);
            list4.AddLast(loc4);
            list5.AddLast(loc5);
            list6.AddLast(loc6);
            word1 = new Word("Hello", 1, list1);
            word2 = new Word("World", 1, list2);
            word3 = new Word("This", 1, list2);
            word4 = new Word("Is", 1, list2);
            word5 = new Word("A", 1, list2);
            word6 = new Word("Test", 1, list2);
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown() { }

        [SetUp] 
        public void SetUp()
        {
            avltree = new AVLTree<Word>();
            avltreeCopy = new AVLTree<Word>();
            removedWordTree = new AVLTree<Word>();
            avltree.InsertItem(word1);
            avltree.InsertItem(word2);
            avltree.InsertItem(word3);
            avltree.InsertItem(word4);
            avltree.InsertItem(word5);
            avltree.InsertItem(word6);
            removedWordTree.InsertItem(word2);
            removedWordTree.InsertItem(word3);
            removedWordTree.InsertItem(word4);
            removedWordTree.InsertItem(word5);
            removedWordTree.InsertItem(word6);
        }

        [TearDown]
        public void TearDown() { }

        [Test]
        public void TestInOrderTree()
        {
            String buffer = "";
            avltree.InOrder(ref buffer);
            Assert.AreEqual("A,Hello,Is,Test,This,World,", buffer, "Did not complete InOrder correctly");
        }

        [Test]
        public void TestPostOrderTree()
        {
            String buffer = "";
            avltree.PostOrder(ref buffer);
            Assert.AreEqual("A,Hello,Test,World,This,Is,", buffer, "Did not PostOrder correctly");
        }

        [Test]
        public void TestPreOrderTree()
        {
            String buffer = "";
            avltree.PreOrder(ref buffer);
            Assert.AreEqual( "Is,Hello,A,This,Test,World,", buffer, "Did not PreOrder correctly");
        }

        [Test]
        public void TestCopyTree()
        {
            avltree.Copy(avltreeCopy);
            String originalBuffer = "";
            avltree.InOrder(ref originalBuffer);
            String copyBuffer = "";
            avltreeCopy.InOrder(ref copyBuffer);
            Assert.AreEqual( copyBuffer, originalBuffer, "Did not copy correctly");
        }

        [Test]
        public void TestCountTree()
        {
            Assert.AreEqual(6, avltree.Count(), "Did not count correctly");
        }

        [Test]
        public void TestHeightTree()
        {
            Assert.AreEqual(2, avltree.Height(), "Did not return correct height");
        }

        [Test]
        public void TestContainsTree()
        {
            Assert.AreEqual(true, avltree.Contains(word1), "Did not return true");
        }

        [Test]
        public void TestFindTree()
        {
            Assert.AreEqual("Hello", avltree.Find(word1).Data._Word, "Did not find word");
        }

        [Test]
        public void TestRemoveTree()
        {
            avltree.removeItem(word1);
            avltree.Copy(avltreeCopy);
            String originalBuffer = "";
            avltree.InOrder(ref originalBuffer);
            String copyBuffer = "";
            removedWordTree.InOrder(ref copyBuffer);
            Assert.AreEqual(copyBuffer, originalBuffer, "Did not remove word correctly");
        }

    }
}
