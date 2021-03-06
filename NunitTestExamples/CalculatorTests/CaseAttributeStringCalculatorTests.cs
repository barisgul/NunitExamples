﻿using NUnit.Framework;

namespace NunitTestExamples.CalculatorTests
{
    [TestFixture]
    public class CaseAttributeStringCalculatorTests
    {
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,3,4", 10)]
        [TestCase("1\n2,3", 6)]
        [TestCase("//;\n1;2", 3)]
        public void Add_SimpleInputs_AddsNumbers(string numbers, int expectedTotal)
        {
            Calculator calculator = new Calculator();

            int total = calculator.Add(numbers);

            Assert.AreEqual(expectedTotal, total);
        }
    }
}
