using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        FizzBuzz fb;
        string _exceptedResult="FizzBuzz 1 2 Fizz 4 Buzz Fizz 7 8 Fizz";
        [TestInitialize]
        public void setUp() 
        {
            fb = new FizzBuzz();
        }

        [TestCleanup]
        public void tearDown() 
        {
            fb = null;
        }

        [TestMethod]
        public void FizzBuzzRuleAnswerTest()
        {
            for (int i = 0; i < 10; i++)
            {
                fb.answer(i);
            }
            Assert.AreEqual(_exceptedResult, fb.getAnswer());
        }
        [TestMethod]
        public void plusFizzNotBuzzleRuleTest() 
        {
            fb.answer(3);
            Assert.AreEqual("Fizz", fb.getAnswer());
        }

        [TestMethod]
        public void plusBuzzNotFizzRuleTest() 
        {
            fb.answer(5);
            Assert.AreEqual("Buzz",fb.getAnswer());
        }
        private bool isFizz(int number) 
        {
            return number % 3 == 0;
        }
    }
}
