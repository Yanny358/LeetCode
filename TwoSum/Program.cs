using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] {3, 2, 5};
            int[] sss = TwoSum(nums, 8);
            foreach (var n in sss)
            {
                Console.WriteLine(n);
            }
            
        }
        
        public static int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
        
            for(int i = 0; i < nums.Length; i++)
            {
                var difference = target - nums[i];
            
                if(dictionary.ContainsKey(difference))
                {
                    return new int[] {dictionary[difference], i};
                }
            
                dictionary[nums[i]] = i;
            }
        
            return nums;
        }

    }
}