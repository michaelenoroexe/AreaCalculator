using AreaCalculator.Calculators;
using AreaCalculator.Shapes;

namespace AreaCalculator
{
    // Статический класс, гарантирующий RAII для калькуляторов площади.
    /// <summary>
    /// Creates area calculator and initialized it with shape.
    /// </summary>
    public static class CalculatorFactory
    {
        /// <summary>
        /// Get area calculator for circle.
        /// </summary>
        public static IAreaCalculator GetCircleCalculator(Circle circle) => new CircleCalculator(circle);
        /// <summary>
        /// Get area calculator for trioangle.
        /// </summary>
        public static IAreaCalculator GetTriangleCalculator(Triangle triangle) => new TriangleCalculator(triangle);
    }
}
