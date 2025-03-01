using NUnit.Framework;
using Parameterized;

namespace ParameterizedTest
{
    [TestFixture]
    public class EvenCheckTest
    {
        private int num;
        private EvenCheck evenCheck;

        [SetUp]
        public void SetUp()
        {
            num = 0;
            evenCheck = new EvenCheck();
        }
        [Test]
        [TestCase(2, ExpectedResult = true)]
        [TestCase(4, ExpectedResult = true)]
        [TestCase(6, ExpectedResult = true)]
        [TestCase(7, ExpectedResult = false)]
        [TestCase(9, ExpectedResult = false)]
        public bool IsEven_TestCases(int number)
        {
            return evenCheck.IsEven(number);
        }

    }
}
