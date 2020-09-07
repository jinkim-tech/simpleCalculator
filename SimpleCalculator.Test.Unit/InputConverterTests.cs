using NUnit.Framework;
using System;
using SimpleCalculator;

namespace SimpleCalculator.Test.Unit
{
    [TestFixture]
    public class InputConverterTests
    {
        private InputConverter _converter;
        
        [SetUp]
        public void SetUp()
        {
            _converter = new InputConverter();
        }

        [Test]
        public void ConvertInputToNumber_WhenInputIsIntString_ReturnDouble()
        {
            double result = _converter.ConvertInputToNumber("10");

            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void ConvertInputToNumber_WhenInputIsDoubleString_ReturnDouble()
        {
            double result = _converter.ConvertInputToNumber("10.1");

            Assert.That(result, Is.EqualTo(10.1));
        }

        [Test]
        public void ConvertInputToNumber_WhenInputIsString_ReturnArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _converter.ConvertInputToNumber("ad"));
        }
    }
}
