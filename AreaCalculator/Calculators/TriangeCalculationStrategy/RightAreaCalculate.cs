using AreaCalculator.Shapes;

namespace AreaCalculator.Calculators.TriangeCalculationStrategy
{
    internal class RightAreaCalculate : IAreaCalculate
    {
        private Triangle triangle;

        public RightAreaCalculate(Triangle triangle) => this.triangle = triangle;

        public double CalculateArea() => (0.5 * (triangle.A * triangle.B)).Round();
    }
}
