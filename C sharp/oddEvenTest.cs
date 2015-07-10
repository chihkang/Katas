using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace BowlingGameTest
{
    [TestClass]
    public class oddEvenTest
    {
        private oddEven oe;

        [TestInitialize]
        public void setUp()
        {
            oe = new oddEven();
        }

        [TestMethod]
        public void TestEvenNumber()
        {
            for (int i = 2; i < 100; i+=2)
            {
                Assert.AreEqual(true, oe.isEven(i));
            }
        }
    }
}
