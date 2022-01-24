using System;
using System.Collections.Generic;
using System.Linq;

namespace Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] {2,3,2,1,3};
            int single = SingleNumber(nums);
            Console.WriteLine(single);
        }

        public static int SingleNumber(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>();
            foreach (var i in nums)
            {
                if (hashSet.Contains(i))
                {
                    hashSet.Remove(i);
                }
                else
                {
                    hashSet.Add(i);
                }
            }

            foreach (var i in hashSet)
            {
                return i;
            }

            return -1;
        }
    }
}