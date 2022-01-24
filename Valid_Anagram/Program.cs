using System;
using System.Collections.Generic;

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
            Dictionary<char,int> collection = new Dictionary<char,int>();

            foreach (var c in s)
            {
                if(collection.ContainsKey(c))
                {
                    collection[c]++;
                    continue;
                }
                collection.Add(c, 1);
            }

            for (int i = 0; i < t.Length; i++)
            {

                if (collection.ContainsKey(t[i]))
                {
                    collection[t[i]]--;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!collection.ContainsKey(t[i]))
                {
                    return false;
                }

                if (collection[t[i]] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}