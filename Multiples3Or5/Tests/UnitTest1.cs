using Multiples3Or5;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(23, Kata.Solution(10));
            Assert.AreEqual(233168, Kata.Solution(1000));
        }
    }
}