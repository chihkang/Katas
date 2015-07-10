using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        Game g; 
        [TestInitialize]
        public void setUp() 
        {
            g = new Game();
        }

        [TestCleanup]
        public void tearDown() 
        {
            g = null;
        }
        [TestMethod]
        public void GutterGameTest() 
        {
            rollMany(0,20);
            Assert.AreEqual(0,g.score());
        }
        [TestMethod]
        public void AllOneTest() 
        {
            rollMany(1, 20);
            Assert.AreEqual(20,g.score());
        }
        [TestMethod]
        public void OneSpareTest() 
        {
            rollSpare();
            g.roll(3);
            rollMany(0,17);
            Assert.AreEqual(16,g.score());
        }
        [TestMethod]
        public void OneStrikeTest() 
        {
            rollStrike();
            g.roll(3);
            g.roll(4);
            rollMany(0,16);
            Assert.AreEqual(24,g.score());
        }
        [TestMethod]
        public void perfectGameTest() 
        {
            rollMany(10,12);
            Assert.AreEqual(300,g.score());
        }
        private void rollMany(int pins,int n) 
        {
            for (int i = 0; i < n; i++)
            {
                g.roll(pins);
            }
        }
        private void rollSpare() 
        {
            g.roll(5);
            g.roll(5);
        }
        private void rollStrike() 
        {
            g.roll(10);
        }
    }
}
