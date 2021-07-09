using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiedCodeBase
{
    public class FirstMissingPostive
    {
        public int FindFirstMissingPostive(int[] numArr = null)
        {
            if (numArr == null)
                numArr = new int[] { 5, 2, 7, 8, 9, 1, 11 };

            var isOneExists = 0;
            var n = numArr.Length;
            int? result = null;
            //Step1: 
            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] == 1) isOneExists = 1;
                if (numArr[i] > n || n < 0)
                {
                    numArr[i] = 1;
                }
            }
            if (isOneExists == 0) return 1;

            //Step2: 
            for (int i = 0; i < numArr.Length; i++)
            {
                var nextIndex = Math.Abs(numArr[i]) - 1;
                if (numArr[nextIndex] > 0)
                    numArr[nextIndex] = -1 * numArr[nextIndex];
            }

            //step3:  
            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] > -1)
                {
                    return i + 1;
                }
            }
            //if (result == null) return n + 1;
            //return (int)result;

            return n + 1;
        }

        public int FirstMissingNumberBF(int[] num = null)
        {
            if (num == null) num = new int[] { 5, 2, 7, 8, 9, 1, 11 };
            int len = num.Length;
            for (int i = 0; i < len; i++)
            {
                if (Array.IndexOf(num, i + 1) < 0)
                    return i + 1;
            }
            return len + 1;
        }
    }
}
