using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiedCodeBase.Arrays
{
    public class SearchIndex
    {
        public int SearchInsert(int[] nums, int target)
        {

            var lo = 0;
            var hi = nums.Length - 1;


            while (hi - lo >= 0)
            {
                var mid = (hi + lo) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    lo = mid + 1;
                else if (nums[mid] > target)
                    hi = mid - 1;

            }
            return lo;




            //var data = nums[0];
            //int result = target < data ? 0 : nums.Length;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (target == nums[i])
            //    {
            //        result = i;
            //        break;
            //    }
            //    if (i > nums.Length - 2) break;
            //    if (target > nums[i] & target < nums[i + 1])
            //    {
            //        result = i + 1;
            //        break;
            //    }
            //}

            //return result;

        }

    }
}
