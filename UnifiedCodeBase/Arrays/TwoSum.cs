using System;
using System.Collections.Generic;
using System.Text;

namespace UnifiedCodeBase
{
    public class TwoSum
    {
        public static void Execute()
        {

            int[] nums = { 2, 16, 11, 15, 7 };
            int target = 9;

            List<int> storeData = new List<int>();
            int data = 0; ;
            int[] output = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {                
                if (storeData.Contains(nums[i]))
                {
                    output[0] = storeData.IndexOf(nums[i]);
                    output[1] = i;
                    break;
                }
                data = target - nums[i];
                storeData.Add(data);
            }
        }
    }
}
