using System;
using System.Linq;

namespace Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(421));

        }

        public static int Reverse(int x)
        {
            int result = 0;
            int reverseNumber = 0;
            while (x != 0)
            {
                int remainder = x % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                if ((reverseNumber - remainder) / 10 != result)
                {
                    return 0;
                }

                result = reverseNumber;
                x /= 10;
            }

            return reverseNumber;
        }
    }
}