using System;
using System.Linq;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            for (string i = "a"; i != "aaa"; i += "a")
            {
                Console.WriteLine("Added an a!");
            }

            Console.ReadKey();

        }
    }

    public class Kata
    {
        public static int GetVowelCount(string str)
        {
            return str.ToArray().Count(a => a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u');
        }
    }
}
