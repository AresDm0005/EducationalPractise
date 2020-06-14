using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task10;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double exp = 0;

            TwoWayList list = new TwoWayList(new double[] { });
            double act = list.Solve();

            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double exp = 36;

            TwoWayList list = new TwoWayList(new double[] { 6 });
            double act = list.Solve();

            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double exp = 1.6;

            TwoWayList list = new TwoWayList(new double[] { 0.5, 0, 1.6});
            double act = list.Solve();

            Assert.AreEqual(exp, act);
        }

        [TestMethod]
        public void TestMethod4()
        {
            double exp = 7.6;

            TwoWayList list = new TwoWayList(new double[] { 0.9, 2, 0.1, 4 });
            double act = list.Solve();

            Assert.AreEqual(exp, act);
        }
    }
}
