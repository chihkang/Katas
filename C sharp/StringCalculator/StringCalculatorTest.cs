using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest.StringCalculator
{
    [TestClass]
    public class StringCalculatorTest
    {
        private StringCalculator sc;

        [TestInitialize]
        public void setUp()
        {
            sc = new StringCalculator();
        }
        [TestMethod]
        public void Test_Add_Empty()
        {     
            Assert.AreEqual(0,sc.Add(""));
        }
        [TestMethod]
        public void Test_Add_One_Number() 
        {
            int n=20;
            Assert.AreEqual(n,sc.Add(n+""));
        }
        [TestMethod]
        public void Test_Add_Two_Number() 
        {
            Assert.AreEqual(6, sc.Add("1\n2,3"));
        }
        [TestMethod]
        public void Test_Add_Other() 
        {
            Assert.AreEqual(3, sc.Add("//;\n1;2"));
        }
        [TestMethod]
        public void Test_Negative_Number() 
        {
            //Assert.AreNotEqual(-1, sc.Add("-1"));
            //sc.Add("-1");
        }
        [TestMethod]
        public void Test_Greater_1000_Number() 
        {
            Assert.AreEqual(0, sc.Add("\\;1001,0\n2000"));
        }
    }
}
