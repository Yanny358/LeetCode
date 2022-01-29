using System;

namespace Rotate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] {1, 2, 3};
            Rotate(arr, 2);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        
        public static void Rotate(int[] nums, int k)
        {
            if (k==0) return;
            
            if (nums == null || nums.Length == 0) return;

            k %= nums.Length;
            reverse(nums, 0, nums.Length - 1);
            reverse(nums, 0,k -1);
            reverse(nums, k, nums.Length -1);
        }

        private static void reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                (nums[start], nums[end]) = (nums[end], nums[start]);
                start++;
                end--;
            }
        }
    }
}