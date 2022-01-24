using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Valid_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "A man, a plan, a canal: Panama";
            Console.WriteLine(IsPalindrome(s));
        }

        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            s = rgx.Replace(s, "");
            Console.WriteLine(s);
            var reverse = Reverse(s);
            Console.WriteLine(reverse);
            return String.Equals(s, reverse);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}