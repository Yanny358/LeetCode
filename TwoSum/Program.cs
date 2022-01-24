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
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (dictionary.ContainsKey(diff))
                {
                    return new[] { dictionary[diff], i };
                }
                
                dictionary.Add(nums[i], i);
            }
            
            return Array.Empty<int>();
        }

    }
}