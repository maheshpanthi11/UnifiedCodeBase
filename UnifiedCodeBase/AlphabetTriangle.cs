using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiedCodeBase
{
    public class AlphabetTriangle
    {
        /// <summary>
        /// O(n)
        /// </summary>
        /// <param name="length"></param>
        public void ShowTriangle(int length = 5)
        {
            //char chars = '*';
            char chars = 'A';

            for (int i = 1; i <= length; i++)
            {
                for (int k = length; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int m = 1; m <= i; m++)
                {
                    Console.Write(chars++);
                    //Console.Write(chars);                    
                }
                chars--;
                chars--;
                for (int l = 1; l < i; l++)
                {
                    Console.Write(chars--);
                    //Console.Write(chars);
                }

                Console.Write("\n");
                chars = 'A';
            }

        }
    }
}
