using NUnit.Framework;
using DecodeMorse6;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string input = ".... . -.--   .--- ..- -.. .";
            string expected = "[L][L][L] [L][L][L][L]";

            string actual = MorseCodeDecoder.Decode(input);

            Assert.AreEqual(expected, actual);
        }
    }
}