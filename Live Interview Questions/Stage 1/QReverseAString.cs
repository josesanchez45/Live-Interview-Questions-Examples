﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QReverseAString
    {
        /* Request: Return the string reversed.
         * 
         * Example: "cat" would return "tac" || "dog" would return "god"
         * "Hello World!" would return "!dlroW olleH"
         * null will return "" (empty string)
         */
        public string ReverseString(string str)
        {
            if (str == null || str.Length == 0)
            {
                return "";
            }
            string str2 = new string(str.Reverse().ToArray());

            return str2;



        }
    }
}
