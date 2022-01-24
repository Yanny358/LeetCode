using System;
using System.Collections.Generic;
using System.Linq;

namespace Contains_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] {1, 2, 3, 4, 4};
            ContainsDuplicate(nums);
        }
        
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Distinct().Count() != nums.Length)
            {
                return true;
            }
            return false;
        }
    }
}