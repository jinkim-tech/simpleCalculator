using System;
using NUnit.Framework;

namespace SimpleCalculator.Test.Unit
{

    [TestFixture]
    public class CalculatorEngineTests
    {
        private CalculatorEngine _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new CalculatorEngine();
        }

        [Test]
        [TestCase("+", 1, 1, 2)]
        [TestCase("add", 1, 1, 2)]
        [TestCase("-", 2, 1, 1)]
        [TestCase("subtract", 2, 1, 1)]
        [TestCase("*", 3, 1, 3)]
        [TestCase("multiply", 3, 1, 3)]
        [TestCase("/", 4, 2, 2)]
        [TestCase("divide", 4, 2, 2)]

        public void Calculuate_WhenCalled_ReturnCalculatedResult(string argOperation, double argFirstNumber, double argSecondNumber, double expectedResult)
        {
            var result = _calculator.Calculate(argOperation, argFirstNumber, argSecondNumber);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Calculate_WhenOperationIsNotValid_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _calculator.Calculate("ad", 1, 2));
        }
    }
}
