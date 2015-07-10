using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BowlingGameTest
{
    class oddEven
    {
        private string _result = "";

        public void printNumber(int from, int end)
        {
            for (int number = from; number < end; number++)
            {
                if (isEven(number)) Trace.WriteLine("Even");
                else if(isOdd(number)) Trace.WriteLine("Odd");
                else Trace.WriteLine(number);
            }
        }

        public bool isEven(int number) 
        {
            return number % 2 == 0;
        }

        public bool isOdd(int number) 
        {
            return !isEven(number) && divisibleByOther(number);
        }
        public bool divisibleByOther(int number) 
        {
            for (int i = 3; i < number/2; i++)
            {
                if (number%i==0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
