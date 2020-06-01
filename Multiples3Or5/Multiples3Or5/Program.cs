using System;

namespace Multiples3Or5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class Kata
    {
        public static int Solution(int value)
        {
            int outSum = 0;

            for (int i = value - 1; i > 0; i--)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    outSum += i;
                }
                else if (i % 3 == 0)
                {
                    outSum += i;
                }
                else if (i % 5 == 0)
                {
                    outSum += i;
                }
            }

            return outSum;
        }
    }
}
