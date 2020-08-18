using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    using NUnit.Framework;

    [TestFixture]
    public class CalculatorEngineTest
    {   
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();
        
        [Test]
        public void AddsTwoNumbersAndReturnsValidResultsForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;

            double result = _calculatorEngine.Calculate("add", number1, number2);

            Assert.AreEqual(3, result);
        }
    }
}
