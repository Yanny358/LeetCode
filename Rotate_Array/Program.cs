using System;

namespace Rotate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] {1, 2, 3, 4 ,5};  // 5,4,3,2,1 // 4,5,3,2,1
            Rotate(arr, 2);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private static void Rotate(int[] nums, int k)
        {
            if (nums.Length < 2  || k < 1)
            {
                return;
            }

            k %= nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        private static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                (arr[start], arr[end]) = (arr[end], arr[start]);
                start++;
                end--;
            }
        }
    }
}