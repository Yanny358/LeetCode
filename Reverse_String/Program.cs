using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str = {'h','y','a','r','g'};

            ReverseString(str);

            foreach (var c in str)
            {
                Console.WriteLine(c);
            }
        }
        

        public static void ReverseString(char[] s)
        {
            int end = s.Length - 1;

            for (int i = 0; i < s.Length / 2; i++)
            {
                (s[i], s[end]) = (s[end], s[i]);
                end--;
            }
        }
    }
}