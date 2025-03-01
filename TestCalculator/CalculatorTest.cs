using Calculators;
using NUnit.Framework;






namespace TestCalculator
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator(5, 3); // Initializing with default values
        }
        [Test]
        public void Add_TwoPositiveNumber_ReturnCorrectSum()
        {
            calculator.num1 = 1;
            calculator.num2 = 2;

            double result = calculator.Add();

            Assert.AreEqual(3, result);

        }

        [Test]
        public void Add_TwoPositiveNumber_ReturnInCorrectSum()
        {
            calculator.num1 = 10000.3;
            calculator.num2 = 152481.636;

            double result = calculator.Add();

            Assert.AreNotEqual(1582785.66, result);
        }

        [Test]
        public void SubStract_TwoPositiveNumber_ReturnInCorrectSubstract()
        {
            calculator.num1 = 10000.3;
            calculator.num2 = 152481.636;

            double result = calculator.Substract();

            Assert.AreNotEqual(1582785.66, result);
        }

        [Test]
        public void SubStract_TwoPositiveNumber_ReturnCorrectSubstract()
        {
            calculator.num1 = 500.50;
            calculator.num2 = 1000.50;

            double result = calculator.Substract();

            Assert.AreEqual(-500.00, result);
        }

        [Test]
        public void Multiply_TwoPositiveNumber_ReturnInCorrectMultiply()
        {
            calculator.num1 = 158222;
            calculator.num2 = 152481.636;

            double result = calculator.Multiply();

            Assert.AreNotEqual(1582785.66, result);

        }
        [Test]
        public void Multiply_TwoPositiveNumber_ReturnCorrectMultiply()
        {
            calculator.num1 = 10000.3;
            calculator.num2 = 0;

            double result = calculator.Multiply();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Divide_TwoPositiveNumber_ReturnInCorrectDivide()
        {
            calculator.num1 = 10000.3;
            calculator.num2 = 152481.636;

            double result = calculator.Divide();

            Assert.AreNotEqual(1582785.66, result);
        }

        [Test]
        public void Divide_TwoPositiveNumber_ReturnCorrectDivide()
        {
            calculator.num1 = 15236;
            calculator.num2 = 3;

            double result = calculator.Divide();

            Assert.AreEqual(5078.66666, result,0.00001f);
        }

        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            calculator.num1 = 10;
            calculator.num2 = 0;

            Assert.Throws<DivideByZeroException>(() => calculator.Divide());
        }
        [Test]
        public void Formate_Exception_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() =>
            {
                double invalidNumber = double.Parse("Invalid");
                calculator.num1 = invalidNumber;
            });

        }
    }
}
