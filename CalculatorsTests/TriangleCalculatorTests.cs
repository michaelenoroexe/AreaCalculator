using AreaCalculator;
using AreaCalculator.Calculators;
using AreaCalculator.Shapes;
using FluentAssertions;

namespace CalculatorsTests
{
    internal class TriangleCalculatorTests
    {
        // Валидные тест кейсы использования калькулятора площади треугольника.
        // Прямоугольные треугольники
        [TestCase(5.0, 6.0, 7.81025, 15.0)]
        [TestCase(3.4, 7.6, 8.32586, 12.92)]
        // Остальные треугольники
        [TestCase(5.0, 4.6, 2.5145, 5.7499)]
        [TestCase(7.6124, 2.7, 6.6847, 8.8999)]
        public void TriangleAreaValidValues(double a, double b, double c, double output)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);
            IAreaCalculator triangleCalculator = CalculatorFactory.GetTriangleCalculator(triangle);
            //Act
            double result = triangleCalculator.GetArea();
            //Assert
            result.Should().Be(output);
        }

        [Test]
        public void TriangleAreaArgumentZeroException()
        {
            //Arrange
            var triangle = new Triangle(0.0, 0.0, 0.0);
            IAreaCalculator triangleCalculator = CalculatorFactory.GetTriangleCalculator(triangle);
            //Assert
            triangleCalculator.Invoking(calc => calc.GetArea()).Should().Throw<ArgumentException>("Incorect shape size");
        }

        // Тесты неординарных значений сторон треугольника.
        [TestCase(double.PositiveInfinity, 1.6, 2.7, "Size of shape is to big")]
        [TestCase(double.MaxValue, 2.6, 2.1, "Size of shape is to big")]
        [TestCase(-1.0, 2.6, 1.2, "Size of shape is negative")]
        [TestCase(double.NegativeInfinity, 6.6, 2.2, "Size of shape is negative")]
        public void TriangleAreaArgumentOutOfRangeException(double a, double b, double c, string exceptionMessage)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);
            IAreaCalculator triangleCalculator = CalculatorFactory.GetTriangleCalculator(triangle);
            //Assert
            triangleCalculator.Invoking(calc => calc.GetArea()).Should().Throw<ArgumentOutOfRangeException>(exceptionMessage);
        }
    }
}
