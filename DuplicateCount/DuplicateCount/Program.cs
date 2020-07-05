using System;

namespace DuplicateCount
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
        public static int DuplicateCount(string str)
        {
            //Indivisibilities
            int count = 0;
            string charactersTest = "";

            foreach (char letter in str.ToLower())
            {
                //If charactersTest does not already contain this letter
                if (charactersTest.IndexOf(letter) < 0)
                {
                    for (int index = 0; index < str.Length - 1; index++)
                    {
                        if (letter == char.ToLower(str[index]) && str.ToLower().IndexOf(letter) != index)
                        {
                            charactersTest += letter;
                            count++;
                            break;
                        }
                    }
                }
            }

            return count;
        }
    }
}
