﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QFibonacci
    {
        /* Request: Return the number at position n in the Fibonacci sequence. The Fibonacci sequence is started with 0, 1 and all additional numbers
         * are the sum of the previous 2. ( 0, 1, 1, 2, 3, 5, 8, 13, 21... )
         * 
         * Example: n = 1 would return 0 since the first position in the sequence is 0. n = 3 would return 1. n = 6 would return 5 so on.. 
         * n < 1 should return 0 since there isnt a position before the first number in the sequence.
         */
        public int FibonacciNumber(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            var list = new List<int>() { 0, 1 };
            for (int i = 2; i < n; i++)
            {
                list.Add(list[i - 2] + list[i - 1]);
            }
            return list[n - 1];
        }
    }
}
