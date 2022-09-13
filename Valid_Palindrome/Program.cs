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
            int start = 0;
            int end = s.Length - 1;
            while(start < end){
                if(!char.IsLetter(s[start])){
                    start++;
                    continue;
                }
            
                if(!char.IsLetter(s[end])){
                    end--;
                    continue;
                }
            
                if(char.ToLower(s[start]) != char.ToLower(s[end])){
                    return false;
                }
            
                start++;
                end--;
            }
        
            return true;
        }
    }
}