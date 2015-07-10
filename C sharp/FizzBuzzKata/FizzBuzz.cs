using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingGameTest
{
    class FizzBuzz :IFizzBuzz    {
        #region private variable

        string _result;
        
        #endregion

        public void answer(int number) 
        {
            if (isFizzBuzz(number)) _result += "FizzBuzz";
            else if(isFizz(number))  _result += "Fizz";
            else if (isBuzz(number)) _result += "Buzz";
            else _result += number.ToString();

            _result += " ";
        }

        public string getAnswer() 
        {
            return _result.Trim();
        }

        private bool isFizz(int number) 
        {
            return number % 3 == 0;
        }

        private bool isBuzz(int number) 
        {
            return number % 5 == 0;
        }
        private bool isFizzBuzz(int number) 
        {
            return number % 15 == 0;
        }
    }
}
