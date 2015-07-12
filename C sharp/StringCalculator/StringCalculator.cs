using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameTest.StringCalculator
{
    class StringCalculator
    {
        private int Sum;

        private char[] defaultDelimter = new char[3];

        public int Add(string number) 
        {
            defaultDelimterSetting();

            return string.IsNullOrEmpty(number) ? 0 : GetSum(number);
        }

        private int GetSum(string number) 
        {
            return isParseInt(number) ? VelidateNumbersArePerRule(Sum) : SplitDelimter_GetSum(number);
        }

        private bool isParseInt(string number) 
        {
            return Int32.TryParse(number,out Sum);
        }

        private int SplitDelimter_GetSum(string number) 
        {   
            int temp=0;

            if(HasSpecificDelimter(number))
            {   
                //start with //
                var new_delimter = GetSpecificDelimter(number);

                addDelimter(new_delimter);
            }

            string[] numbers = number.Split(defaultDelimter);

            foreach (var item in numbers)
            {
                if (isParseInt(item)) temp += GreaterThan1000(Sum);
            }
 
            return temp;
        }

        private bool HasSpecificDelimter(string number)
        {
            return number.StartsWith("//");
        }
        private char[] getDelimter() 
        {   
            return defaultDelimter;
        }

        private void addDelimter(char[] delimter) 
        {
            defaultDelimter[2] = delimter[0];
        }

        private char[] GetSpecificDelimter(string number)
        {
            return number.Substring(2, number.IndexOf("\n") - 2).ToCharArray();
        }
        private void defaultDelimterSetting()
        {
            defaultDelimter[0] = '\n';
            defaultDelimter[1] = ',';
        }
        private int VelidateNumbersArePerRule(int number) 
        {
            if (number < 0)
            {
                throw new ArgumentException(string.Format("string contains [{0}], which does not meet rule. entered number should not negative.", number));
            }
            else 
            {
                return GreaterThan1000(number);
            }
        }
        private int GreaterThan1000(int number) 
        {
            return number > 1000 ? 0 : number;
        }
    }
}
