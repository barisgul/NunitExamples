using NUnit.Framework;

namespace NunitTestExamples.CalculatorTests
{
    public class SimpleStringCalculatorTests
    {
        private Calculator calculator;
        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_EmptyString_ReturnsZero()
        {  
            int total = calculator.Add("");

            Assert.AreEqual(0, total);
        }

        [Test]
        public void Add_SingleNumber_ReturnsTheNumber()
        { 
            int total = calculator.Add("1");

            Assert.AreEqual(1, total);
        }

        [Test]
        public void Add_TwoNumbers_ReturnsTheTotal()
        { 
            int total = calculator.Add("1,2");

            Assert.AreEqual(3, total);
        }
    }
    }
