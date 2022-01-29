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

            char[] sChar = s.ToCharArray();
            char[] tChar = t.ToCharArray();
            Array.Sort(sChar);
            Array.Sort(tChar);
            
            bool isEqual = sChar.SequenceEqual(tChar);

            return isEqual;
        }
    }
}