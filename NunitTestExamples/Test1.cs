using NUnit.Framework;

namespace NunitTestExamples
{
    [TestFixture]
    class Test1
    {
        private int a;
        [SetUp]
        public void SetUp()
        {
            TestContext.Progress.WriteLine("SetUp");
            a = 5;
        }

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(3 + 2, 5, "Hata Alındı");
        }

         
        [TestCase(4,1)]
        [TestCase(2,3)]
        public void TestMethod2(params int[] testData) 
        {
            int restult = testData[0] + testData[1];

            Assert.AreEqual(restult, a, "Hata Alındı"); 
        }

        [Test]
        public void TestMethod3([Values(2, 3)] int x, [Values(1, 3)] int y) 
        {
            Assert.GreaterOrEqual(x + y, 3, "Hata Alındı"); 
        }

        [TearDown]
        public void TearDown()
        {

        }

    }
}
