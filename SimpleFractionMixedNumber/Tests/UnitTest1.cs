using System;
using NUnit.Framework;
using SimpleFractionMixedNumber;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual("4 2/3", Kata.MixedFraction("42/9"));
            Assert.AreEqual("2", Kata.MixedFraction("6/3"));
            Assert.AreEqual("1", Kata.MixedFraction("1/1"));
            Assert.AreEqual("1", Kata.MixedFraction("11/11"));
            Assert.AreEqual("2/3", Kata.MixedFraction("4/6"));
            Assert.AreEqual("0", Kata.MixedFraction("0/18891"));
            Assert.AreEqual("-1 3/7", Kata.MixedFraction("-10/7"));
            Assert.AreEqual("3 1/7", Kata.MixedFraction("-22/-7"));
            Assert.AreEqual("-195595/564071", Kata.MixedFraction("-195595/564071"));
            Assert.AreEqual("-493/751", Kata.MixedFraction("493/-751"));

            Assert.Throws(typeof(DivideByZeroException), delegate { Kata.MixedFraction("0/0"); });
            Assert.Throws(typeof(DivideByZeroException), delegate { Kata.MixedFraction("3/0"); });
        }
    }
}