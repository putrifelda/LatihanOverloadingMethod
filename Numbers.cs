using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            //int min;
            if (number1 < number2)
                return number1;
            else
                return number2;
            //return min;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            int min;
            int a = (int)number3;
            if (number1 < number2 && number1 < a)
                min = number1;
            else if (number2 < number1 && number2 < a)
                min = number2;
            else
                min = a;
            return min;
        }    
            
        public int FindMaximum(int number1, int number2)
        {
            int max;
            if (number1 > number2)
                max = number1;
            else
                max = number2;
            return max;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int max;
            int a = (int)number3; // float to integer
            if (number1 > number2 && number1 > a)
                max = number1;
            else if (number2 > number1 && number2 > a)
                max = number2;
            else
                max = a;
            return max;

        }

    }
}
