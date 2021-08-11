    using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiedCodeBase
{
    public class MergeArray
    {
        public static void Execute()
        {
            int[] firstArray = { 1, 2, 3, 5, 7, 8 };
            int[] secondArray = { 1, 5, 7, 8, 12, 13 };

            var farIndex = 0;
            var sarIndex = 0;

            int? firstVal = firstArray[farIndex];
            int? secondVal = secondArray[sarIndex];

            List<int> finalArray = new List<int>();

            while (firstVal != null || secondVal != null)
            {
                if (firstVal != null && (secondVal == null || ((int)firstVal < (int)secondVal)))
                {
                    finalArray.Add((int)firstVal);
                    farIndex++;
                }
                else if (secondVal != null && (firstVal == null || (firstVal > secondVal)))
                {
                    finalArray.Add((int)secondVal);
                    sarIndex++;
                }
                else
                {
                    finalArray.Add((int)secondVal);
                    farIndex++;
                    sarIndex++;
                }

                if (farIndex > firstArray.Length - 1) firstVal = null;
                else firstVal = firstArray[farIndex];

                if (sarIndex > secondArray.Length - 1) secondVal = null;
                else secondVal = secondArray[sarIndex];
            }

            finalArray.ForEach(a => Console.WriteLine(a));
        }

    }
}
