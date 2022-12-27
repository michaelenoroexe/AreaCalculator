using AreaCalculator.Shapes;

namespace AreaCalculator.Calculators.TriangeCalculationStrategy
{
    internal class EquilateralAreaCalculate : IAreaCalculate
    {
        private Triangle triangle;

        public EquilateralAreaCalculate(Triangle triangle) => this.triangle = triangle;

        public double CalculateArea() => (Math.Sqrt(3) * triangle.A.Sqr() / 4).Round();
    }
}
