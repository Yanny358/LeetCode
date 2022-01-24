using System;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {3, 2, 2, 3};
            RemoveElement(nums, 2);
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }
            
        }

        public static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            var zeroIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[zeroIndex] = nums[i];
                    zeroIndex++;
                }

            }

            return zeroIndex;
        }
    }
}