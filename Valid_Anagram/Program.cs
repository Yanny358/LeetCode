using System;
using System.Collections.Generic;
using System.Linq;

namespace Valid_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "bob";
            string s2 = "obb";
            Console.WriteLine(IsAnagram(s1,s2));
            
        }
        
        public static bool IsAnagram(string s, string t) {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> sMap = new Dictionary<char, int>();

            foreach (var character in s)
            {
                if (!sMap.ContainsKey(character))
                {
                    sMap.Add(character, 1);
                    continue;
                }

                sMap[character]++;
            }

            foreach (var character in t)
            {
                if (!sMap.ContainsKey(character) || sMap[character] == 0)
                {
                    return false;
                }

                sMap[character]--;
            }

            return true;
        }
    }
}