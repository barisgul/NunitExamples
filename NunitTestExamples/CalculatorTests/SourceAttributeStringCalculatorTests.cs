using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestExamples.CalculatorTests
{
    [TestFixture]
    public class SourceAttributeStringCalculatorTests
    {

        private static IEnumerable<TestCaseData> AddCases()
        {
            yield return new TestCaseData("", 0);
            yield return new TestCaseData("1", 1);
            yield return new TestCaseData("1,2", 3);
            yield return new TestCaseData("1,2,3,4", 10);
            yield return new TestCaseData("1\n2,3", 6);
            yield return new TestCaseData("//;\n1;2", 3);
        }

        [Test, TestCaseSource("AddCases")]
        public void Add_SimpleInputs_AddsNumbers(string numbers, int expectedTotal)
        {
            Calculator calculator = new Calculator();

            int total = calculator.Add(numbers);

            Assert.AreEqual(expectedTotal, total);
        }

    }
}
