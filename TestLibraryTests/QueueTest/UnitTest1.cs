using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary.Computer;

namespace TestLibraryTests.QueueTest
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void Method1()
        {
            CustomQueue cq = new CustomQueue();
            cq.Enqueue(10);
            cq.Enqueue(20);
            cq.Enqueue(30);

            Assert.AreEqual(3, cq.Count, 0);

            var tmp = cq.GetItem();
            Assert.AreEqual(3, tmp.Length);

        }

        [TestMethod]
        public void StackV2Test()
        {
            CustomStackV2 cs = new CustomStackV2();
            for (int i = 0; i < 20; i++)
            {
                cs.Push(i * 10);
            }

            Assert.AreEqual(20, cs.Count);
            cs.Pop();
            Assert.AreEqual(19, cs.Count);
        }
    }
}













