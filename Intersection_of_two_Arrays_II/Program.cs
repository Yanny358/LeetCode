using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Intersection_of_two_Arrays_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] {4,9,5};
            int[] arr2 = new int[] {9,4,9,8,4};

            int[] arr3 = Intersect(arr1, arr2);
            foreach (var num in arr3)
            {
                Console.WriteLine(num);
            }
        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();
            List<int> result = new List<int>();
            foreach(int num in nums1){
                if(map.ContainsKey(num)) map[num]++;
                else map.Add(num,1);
            }
            foreach(int num in nums2){
                if(map.ContainsKey(num))
                {
                    map[num]--;
                    result.Add(num);
                    if (map[num] == 0)
                    {
                        map.Remove(num);
                    }
                }
            }
            return result.ToArray(); 
        }
    }
}