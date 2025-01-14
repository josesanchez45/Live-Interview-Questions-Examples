﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QFizzBuzz
    {
        /* Request: Return "Fizz" if the num is divisible by 3.
         * Return "Buzz" if the num is divisible by 5.
         * Return "FizzBuzz" if the num is divisible by 3 and 5.
         * Return the number as a string if it is not divisible by 3 or 5.
         * 
         * Example: 9 would return "Fizz". 10 would return "Buzz".
         * 15 would return "FizzBuzz". 7 would return "7".
         */
        public string FizzBuzz(int num)
        {
            var result = "";
            
            if(num % 3 == 0 && num % 5 != 0)
            {
                return "Fizz";
            }
            if(num % 5 == 0 && num % 3 != 0)
            {
                return "Buzz";
            }
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if(num % 3 != 0 && num % 5 != 0)
            {
                return num.ToString();
            }
            return result;
        }
    }
}
