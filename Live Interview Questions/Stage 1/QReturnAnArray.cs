using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QReturnAnArray
    {
        // RETURN AN EMPTY ARRAY OF STRINGS
        public string[] ReturnEmptyStringArray()
        {
            string[] array = new string[0];
            return array;
        }

        // RETURN AN EMPTY ARRAY OF INTEGERS 
        public int[] ReturnEmptyIntArray()
        {
            int[] array = new int[0];
            return array ;
        }

        // RETURN AN ARRAY OF INTEGERS FROM 1 TO N
        // Example: n = 1 would return int[] { 1 }.
        // n = 3 would return int[] { 1, 2, 3 }.
        public int[] ReturnIntArrayFrom1ToN(int n)
        {
            int x = 0;
            List<int> numlist = new List<int>();
            while (x < n)
            {
                x++;
                numlist.Add(x);
            }
            return numlist.ToArray();
            

        }
    }
}
