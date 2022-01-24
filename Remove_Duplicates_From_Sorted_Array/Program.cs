using System;


namespace Remove_Duplicates_From_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] {1,1,2};
            RemoveDuplicates(nums);
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }

            int uniq = RemoveDuplicates(nums);
            Console.WriteLine("Unique numbers in array: ");
            Console.WriteLine(uniq);
        }
        
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int uniques = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[uniques])
                {
                    uniques++;
                    nums[uniques] = nums[j];
                }
            }

            return uniques + 1;
        }
    }
}