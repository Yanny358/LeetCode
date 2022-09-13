using System;
using System.Collections.Generic;

namespace Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[] { 1,2,2 };
            int[] d = PlusOne(digits);
            foreach (var n in d)
            {
                Console.WriteLine(n);
            }
        }

        public static int[] PlusOne(int[] digits)
        {
            int[] biggerDigits = new int [digits.Length + 1];

            int i = digits.Length - 1;
            if (digits[i] != 9)
            {
                digits[i] += 1;
                return digits;
            }

            while (digits[i] == 9 && i > 0)
            {
                digits[i] = 0;
                i--;
            }

            if (digits[i] != 9)
            {
                digits[i] += 1;
                return digits;
            }

            biggerDigits[0] = 1;
            return biggerDigits;
        }
    }
}