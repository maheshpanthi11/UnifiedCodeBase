using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiedCodeBase
{
    // https://leetcode.com/problems/contains-duplicate/
    // Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    // Example 1:
    // Input: nums = [1,2,3,1]
    // Output: true
    // Example 2:
    // Input: nums = [1,2,3,4]
    // Output: false
    // Example 3:
    // Input: nums = [1,1,1,3,3,4,3,2,4,2]
    // Output: true
    public class ContainsDuplicate
    {

        public bool ContainsDuplicateItems(int[] nums)
        {
            List<int> store = new List<int>();
            bool result = false;
            foreach (var item in nums)
            {
                if (store.Contains(item))
                {
                    result = true;
                    break;
                };
                store.Add(item);
            }
            return result;

        }
    }
}
