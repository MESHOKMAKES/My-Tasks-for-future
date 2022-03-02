using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Solver.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Linked_List.LinkedList linkedList = new Linked_List.LinkedList();
            for (int i = 0; i < 5; i++)
            {
                Linked_List.Node node = new Linked_List.Node(i);
                linkedList.AddFirst(node);
            }
            Assert.AreEqual(linkedList.Search(0).val, 4);
            Assert.AreEqual(linkedList.Search(1).val, 3);
            Assert.AreEqual(linkedList.Search(2).val, 2);
            Assert.AreEqual(linkedList.Search(3).val, 1);
            Assert.AreEqual(linkedList.Search(4).val, 0);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Linked_List.Node node = new Linked_List.Node(1);
            Assert.AreEqual("1", node.ToString());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Linked_List.LinkedList linkedList = new Linked_List.LinkedList();
            for (int i = 0; i < 5; i++)
            {
                Linked_List.Node node = new Linked_List.Node(i);
                linkedList.AddFirst(node);
            }
            Assert.AreEqual(linkedList.len, 5);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Linked_List.LinkedList linkedList = new Linked_List.LinkedList();
            for (int i = 0; i < 5; i++)
            {
                Linked_List.Node node = new Linked_List.Node(i);
                linkedList.AddLast(node);
            }
            linkedList.AddAfter(linkedList.Search(0), new Linked_List.Node(9));
            Assert.AreEqual(linkedList.len, 6);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Linked_List.LinkedList linkedList = new Linked_List.LinkedList();
            for (int i = 0; i < 5; i++)
            {
                Linked_List.Node node = new Linked_List.Node(i);
                linkedList.AddLast(node);
            }
            linkedList.Clear();
            Assert.AreEqual(linkedList.head, null);
        }
        [TestMethod]
        public void TestMethod6()
        {
            Linked_List.LinkedList linkedList = new Linked_List.LinkedList();
            for (int i = 0; i < 5; i++)
            {
                Linked_List.Node node = new Linked_List.Node(i);
                linkedList.AddLast(node);
            }
            linkedList.Remove(linkedList.Search(0));
            Assert.AreEqual(linkedList.len, 4);
            Assert.AreEqual(linkedList.head.val, 1);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Linked_List.LinkedList linkedList = new Linked_List.LinkedList();
            for (int i = 0; i < 5; i++)
            {
                Linked_List.Node node = new Linked_List.Node(i);
                linkedList.AddLast(node);
            }
            Assert.AreEqual(linkedList.FindByVaL(1).val, 1);
        }
        [TestMethod]
        public void TestMethod8()
        {
            Linked_List.LinkedList linkedList = new Linked_List.LinkedList();
            for (int i = 0; i < 5; i++)
            {
                Linked_List.Node node = new Linked_List.Node(i);
                linkedList.AddLast(node);
            }
            linkedList.AddLast(new Linked_List.Node(2));
            linkedList.AddLast(new Linked_List.Node(2));
            linkedList.AddLast(new Linked_List.Node(2));
            linkedList.AddLast(new Linked_List.Node(2));
            Assert.AreEqual(linkedList.FindAllByVal(2).len, 5);
        }
        [TestMethod]
        public void TestMethod9()
        {
            Linked_List.LinkedList linkedList = new Linked_List.LinkedList();
            for (int i = 0; i < 5; i++)
            {
                Linked_List.Node node = new Linked_List.Node(i);
                linkedList.AddLast(node);
            }
            linkedList.AddLast(new Linked_List.Node(2));
            linkedList.AddLast(new Linked_List.Node(2));
            linkedList.AddLast(new Linked_List.Node(2));
            linkedList.AddLast(new Linked_List.Node(2));
            
            Assert.AreEqual(linkedList.RemoveAllByVal(2), true);
        }
        
    }
}
