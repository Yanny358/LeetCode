using System;
using System.Collections.Generic;

namespace First_Unique_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = "aaaabbbccd";
            int single = FirstUniqChar(nums);
            Console.WriteLine(single);
        }
        
        public static int FirstUniqChar(string s)
        {
            Dictionary<char,int> collection = new Dictionary<char,int>();
    
            foreach(var item in s)
            {
                if(collection.ContainsKey(item))
                {
                    collection[item]++;
                    continue;
                }
               
                collection.Add(item, 1);
                  
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (collection[s[i]] == 1)
                {
                    return i;
                }
            }
    
            return -1;
        }
    }
}