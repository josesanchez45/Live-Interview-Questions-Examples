using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Interview_Questions
{
    public class QSumTwoToTargetNumber
    {
        /* Request: Return if two different elements in arr can add together to equal the target number.
         * 
         * Example: arr = { 1, 3, 5 } and target = 6 would return TRUE since 1 + 5 = 6.
         * arr = { 1, 3, 5 } and target = 4 would return TRUE since 1 + 3 = 4.
         * arr = { 1, 3, 5 } and target = 3 would return FALSE since none of the numbers add up to equal 3.
         */
        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] arr, int target)
        {
            var result = false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 1; j < arr.Length - 1; j++)
                {
                    if(arr[i] + arr[j] == target || arr[i] + arr [j+1] == target)
                    {
                        result = true;
                    }
                }
            }
            return result;
            
        }
    }
}
