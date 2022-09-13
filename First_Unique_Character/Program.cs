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
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (var character in s)
            {
                if (!map.ContainsKey(character))
                {
                    map.Add(character, 1);
                    continue;
                }

                map[character]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (map[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}