using System;
using System.Collections.Generic;
using System.Linq;

namespace NextBiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Kata
    {
        public static long NextBiggerNumber(long n)
        {
            long returnLong = n;
            List<int> digits = new List<int>();

            for (int i = 0; i < Math.Ceiling(Math.Log10(n)); i++)
            {
                digits.Add(Convert.ToInt32(returnLong % 10));
                returnLong = returnLong / 10;
            }

            digits.Reverse();

            int passes = 0;

            //while (passes < digits.Count)
            //{
            //    int maxDigitPosition = digits.IndexOf(digits.Max());

            //}

            //int maxDigitValue = digits.;
            //int maxDigitPosition = digits.IndexOf(digits.Max());

            //while (returnlong <= n && passes < digits.Count)
            //{
            //    digits.RemoveAt(maxDigitPosition);
            //    digits.Insert(maxDigitPosition - 1, maxDigitValue);
            //    maxDigitPosition--;
            //}

            //returnLong = long.Parse(string.Join("", digits));

            //if (returnLong <= n)
            //{
            //    return -1;
            //}

            return returnLong;
        }
    }
}
