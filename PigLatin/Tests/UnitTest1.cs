using NUnit.Framework;

namespace PigLatin
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
        }
    }
}