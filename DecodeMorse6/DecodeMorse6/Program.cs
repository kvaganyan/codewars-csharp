using System;
using System.Collections.Generic;
using System.Linq;

namespace DecodeMorse6
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            return string.Join(" ",
                morseCode.Split("   ").Select(
                    word => string.Join("", word.Split(' ').Select(
                        letter => MorseCode.Get(letter)
                        )
                    ))).Trim();
        }
    }

    public static class MorseCode
    {
        public static string Get(string code)
        {
            return "[L]";
        }
    }
}
