using NUnit.Framework;
using Calculator;

namespace Tests
{
    public class Tests
    {
        Evaluator Evaluator { get; set; } = new Evaluator();

        [Test]
        [TestCase("1-1", ExpectedResult = 0)]
        [TestCase("1+1", ExpectedResult = 2)]
        [TestCase("1 - 1", ExpectedResult = 0)]
        [TestCase("1* 1", ExpectedResult = 1)]
        [TestCase("1 /1", ExpectedResult = 1)]
        public double TestEvaluation(string expression)
        {
            return Evaluator.Evaluate(expression);
        }
    }
}