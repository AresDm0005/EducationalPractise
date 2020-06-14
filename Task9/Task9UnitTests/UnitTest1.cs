using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task9;

namespace Task9UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IterativeSumTest1()
        {
            int exp = 0;

            List list = new List(new int[] { });
            int act = list.SumIterative();

            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void IterativeSumTest2()
        {
            int exp = -1;

            List list = new List(new int[] { -1 });
            int act = list.SumIterative();

            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void IterativeSumTest3()
        {
            int exp = 19;

            List list = new List(new int[] { 1, -10, 5, 9, 14 });
            int act = list.SumIterative();

            Assert.AreEqual(exp, act);
        }


        [TestMethod]
        public void RecursiveSumTest1()
        {
            int exp = 0;

            List list = new List(new int[] { });
            int act = list.SumRecursive();

            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void RecursiveSumTest2()
        {
            int exp = 50;

            List list = new List(new int[] { 50 });
            int act = list.SumRecursive();

            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void RecursiveSumTest3()
        {
            int exp = 0;

            List list = new List(new int[] { 4, -10, 13, 2, -9});
            int act = list.SumRecursive();

            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void SumTest()
        {
            bool exp = true;

            List list = new List(new int[] { 1, 10, -8, 16, 4 });
            bool act = list.SumIterative() == list.SumRecursive();

            Assert.AreEqual(exp, act);
        }
    }
}
