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
            //Convert to string
            //Create return long and set to 0
            //For loop length of string
            //Pull last char one step to the right and check if bigger then original

            string originLongString = n.ToString();
            long newLong = 0;

            while (newLong < n && newLong != -1)
            {

            }
        }
    }
}
