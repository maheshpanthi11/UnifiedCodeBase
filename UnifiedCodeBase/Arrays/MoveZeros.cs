using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiedCodeBase
{

    /// <summary>
    /// https://leetcode.com/problems/move-zeroes/
    /// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    //  Note that you must do this in-place without making a copy of the array.
    //    Example 1:
    //    Input: nums = [0, 1, 0, 3, 12]
    //    Output: [1,3,12,0,0]
    //    Example 2:
    //    Input: nums = [0]
    ///    Output: [0]
    /// </summary>
    class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                if (sum > 0)
                {
                    nums[counter] = sum;
                    nums[i] = 0;
                    sum = 0;
                    counter++;
                }
            }
        }
    }
}
