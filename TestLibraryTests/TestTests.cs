using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Tests
{
    [TestClass()]
    public class TestTests
    {
        [TestMethod()]
        public void TestNonStaticTest()
        {
            Test t = new Test();

            int res = t.TestNonStatic();

            Assert.AreEqual(11, res, 0, "They are not equal.");
            
            

        }

        [TestMethod()]
        public void TestNonStaticTest1()
        {
            Test t = new Test();

            int res = t.TestNonStatic();


            Assert.IsNotNull(res);
           

        }

        [TestMethod()]
        public void TestNonStaticTest2()
        {
            Test t = new Test();

            int res = t.TestNonStatic();

            Assert.IsInstanceOfType(res, typeof(int));

        }
    }
}