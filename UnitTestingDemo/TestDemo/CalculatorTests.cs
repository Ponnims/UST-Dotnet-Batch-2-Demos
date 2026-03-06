using NUnit.Framework;
using Application;
using System;

namespace TestDemo
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TestCase(5, 10, 15)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, 7, 4)]
        [TestCase(-5, -6, -11)]
        public void Add_ShouldReturnSum_WhenGivenTwoNumbers(int a, int b, int expected)
        {
            int actual = _calculator.Add(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(10, 5, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, 7, -10)]
        [TestCase(-5, -6, 1)]
        public void Subtract_ShouldReturnDifference_WhenGivenTwoNumbers(int a, int b, int expected)
        {
            int actual = _calculator.Subtract(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(5, 10, 50)]
        [TestCase(0, 123, 0)]
        [TestCase(-3, 7, -21)]
        [TestCase(-5, -6, 30)]
        public void Multiply_ShouldReturnProduct_WhenGivenTwoNumbers(int a, int b, int expected)
        {
            int actual = _calculator.Multiply(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(10, 2, 5.0)]
        [TestCase(7, 2, 3.5)]
        [TestCase(0, 5, 0.0)]
        [TestCase(-9, 3, -3.0)]
        public void Divide_ShouldReturnQuotient_WhenGivenTwoNumbers(int a, int b, double expected)
        {
            double actual = _calculator.Divide(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}
