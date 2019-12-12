using Microsoft.VisualStudio.TestTools.UnitTesting;
using BID.SWE.EXAM.Impl;


namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Ex2Meth2_1()
        {
            var x = new Exercise2();
            int size = x.Method2();
            Assert.AreEqual(size, 2);
        }

        [TestMethod]
        public void Ex2Meth3_1()
        {
            var x = new Exercise2();
            bool alive = x.Method3(4);
            Assert.AreEqual(alive, true);
        }

        [TestMethod]
        public void Ex2Meth3_2()
        {
            var x = new Exercise2();
            bool alive = x.Method3(7);
            Assert.AreEqual(alive, false);
        }
    }
}
