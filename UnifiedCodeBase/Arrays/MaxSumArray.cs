﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiedCodeBase
{
    /// <summary>
    /// Maximum Subarray
    /// Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
    ///    A subarray is a contiguous part of an array.
    ///    Example 1:
    /// Input: nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
    ///    Output: 6
    ///   Explanation: [4,-1,2,1] has the largest sum = 6.
    ///    Example 2:
    ///    Input: nums = [1]
    ///    Output: 1
    ///    Example 3:
    ///    Input: nums = [5, 4, -1, 7, 8]
    ///    Output: 23
    /// </summary>
    class MaxSumArray
    {
        /// <summary>
        /// kaden's algorithm
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxSubArray(int[] nums)
        {

            int maxSum = 0;
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum = currentSum + nums[i];
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }

            return maxSum;
        }
    }
}
