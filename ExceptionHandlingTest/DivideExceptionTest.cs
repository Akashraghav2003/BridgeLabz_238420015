using NUnit.Framework;
using ExceptionHandling;

namespace ExceptionHandlingTest
{
    [TestFixture]
    public class DivideExceptionTest
    {
        private double divisor;
        private double divident;

        [SetUp]
        public void SetUp()
        {
            divisor = 1;
            divident = 1;
        }

        [Test]
        public void Divide_throwDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => DivideException.Divide(10, 0));
        }
        [Test]
        public void Divide_number_ReturnDividedValue()
        {
            divident = 10;
            divisor = 500;

            double result = DivideException.Divide( divisor, divident);

            Assert.AreEqual(50, result);
        }


    }
}
