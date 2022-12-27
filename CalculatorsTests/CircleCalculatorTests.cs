using AreaCalculator;
using AreaCalculator.Calculators;
using AreaCalculator.Shapes;
using FluentAssertions;

namespace CalculatorsTests
{
    public class CircleCalculatorTests
    {
        // ¬алидные тест кейсы использовани€ калькул€тора.
        [TestCase(5.0, 78.5398)]
        [TestCase(7.6124, 182.051)]
        public void CircleAreaValidValues(double input, double output)
        {
            //Arrange
            Circle circle = new Circle(input);
            IAreaCalculator circleCalculator = CalculatorFactory.GetCircleCalculator(circle);
            //Act
            double result = circleCalculator.GetArea();
            //Assert
            result.Should().Be(output);
        }

        [Test]
        public void CircleAreaArgumentZeroException()
        {
            //Arrange
            Circle circle = new Circle(0.0);
            IAreaCalculator circleCalculator = CalculatorFactory.GetCircleCalculator(circle);
            //Act

            //Assert
            circleCalculator.Invoking(calc => calc.GetArea()).Should().Throw<ArgumentException>("Incorect shape size");
        }

        [TestCase(double.PositiveInfinity, "Size of shape is to big")]
        [TestCase(double.MaxValue, "Size of shape is to big")]
        [TestCase(-1.0, "Size of shape is negative")]
        [TestCase(double.NegativeInfinity, "Size of shape is negative")]
        public void CircleAreaArgumentOutOfRangeException(double input, string exceptionMessage)
        {
            //Arrange
            Circle circle = new Circle(input);
            IAreaCalculator circleCalculator = CalculatorFactory.GetCircleCalculator(circle);
            //Assert
            circleCalculator.Invoking(calc => calc.GetArea()).Should().Throw<ArgumentOutOfRangeException>(exceptionMessage);
        }
    }
}