using System;
using NUnit.Framework;
using Concept_Calculator;

namespace Concept_Calculator_Test
{
    [TestFixture]
    class CalculatorTests
    {
        private Calculator calc = null;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void isValidValueEnteredLetter()
        {
            bool result;

            result = calc.isValueValid("e");

            Assert.IsFalse(result, "Value should be valid!");
        }
    }
}
