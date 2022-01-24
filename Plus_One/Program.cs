using System;
using System.Collections.Generic;

namespace Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[] {9,8,9};
            int[] d = PlusOne(digits);
            foreach (var n in d)
            {
                Console.WriteLine(n);
            }
        }
        
        public static int[] PlusOne(int[] digits)
        {
            int[] newArr = new int[digits.Length + 1];

            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1] += 1;
                return digits;
            }

            int i = digits.Length - 1;
            if (digits.Length > 1)
            {
                while (digits[i] == 9 && i > 0 )
                {
                    digits[i] = 0;
                    i--;
                }

                if (digits[i] != 9)
                {
                    digits[i] += 1;
                    i--;
                    return digits;
                }
            }

            newArr[0] = 1;
            return newArr;
        }
    }
}