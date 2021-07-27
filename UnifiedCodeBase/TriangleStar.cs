using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiedCodeBase
{
    public class TriangleStar
    {
        /// <summary>
        /// O(length^2)
        /// </summary>
        /// <param name="length"></param>
        public void MakeStar(int length = 8)
        {
            for (int i = 1; i <= length; i++)
            {
                var len = (length - i + 1) + (2 * i - 1);
                for (int j = 1; j <= len; j++)
                {
                    if (j <= length - i + 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
