using NUnit.Framework;
using NextBiggerNumber;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(21, Kata.NextBiggerNumber(12));
            Assert.AreEqual(531, Kata.NextBiggerNumber(513));
            Assert.AreEqual(2071, Kata.NextBiggerNumber(2017));
            Assert.AreEqual(441, Kata.NextBiggerNumber(414));
            Assert.AreEqual(414, Kata.NextBiggerNumber(144));
        }
    }
}