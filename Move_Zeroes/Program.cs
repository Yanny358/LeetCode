using System;

namespace Move_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {0, 1, 0, 3, 12};  
            MoveZeroes(nums);
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }
        }
        
        public static void MoveZeroes(int[] nums)
        {
            var zeroIndex = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != 0) {
                    (nums[i], nums[zeroIndex]) = (nums[zeroIndex], nums[i]);
                }

                if (nums[zeroIndex] != 0) {
                    zeroIndex++;
                }
            }
        }
    }
}