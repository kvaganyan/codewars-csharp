using System;

namespace PigLatin
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
        public static string PigIt(string str)
        {
            string returnString = string.Empty;

            foreach (string s in str.Split(' '))
            {
                if (s.Length >= 2)
                {
                    returnString += s.Substring(1, s.Length - 1);
                    returnString += s[0];
                    returnString += "ay";
                    returnString += " ";
                }
            }

            return returnString.Trim();
        }
    }
}
