using System;

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
            string originLongString = n.ToString();
            long returnLong = 0;
            char digitOne = originLongString[0];
            char digitTwo = originLongString[1];
            char digitThree = originLongString[2];
            char digitFour = originLongString[3];

            for (int i=0; i<= originLongString.Length;i++)
            {

            }

            return returnLong;
        }
    }
}
