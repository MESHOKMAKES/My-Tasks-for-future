using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Solver
{
    [TestClass]
    public class SolverTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Linked_List___generic_type.LinkedList<int> linkedList = new Linked_List___generic_type.LinkedList<int>();
            for(int i = 0; i < 5; i++)
            {
                linkedList.AddFirst(i);
            }
            Assert.AreEqual(linkedList.Search(3).val, 3);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Linked_List___generic_type.LinkedList<int> linkedList = new Linked_List___generic_type.LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                linkedList.AddFirst(i);
            }
            linkedList.AddAfter(linkedList.Search(3), 9);
            Assert.AreEqual(linkedList.Search(4).val, 9);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Linked_List___generic_type.LinkedList<int> linkedList = new Linked_List___generic_type.LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                linkedList.AddFirst(i);
            }
            linkedList.AddAfter(linkedList.Search(3), 9);
            Assert.AreEqual(linkedList.Exist(linkedList.Search(4)), true);
            
        }
    }
}
