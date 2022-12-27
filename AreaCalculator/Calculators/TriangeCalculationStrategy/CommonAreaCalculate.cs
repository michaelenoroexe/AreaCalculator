using AreaCalculator.Shapes;

namespace AreaCalculator.Calculators.TriangeCalculationStrategy
{
    internal class CommonAreaCalculate : IAreaCalculate
    {
        private Triangle triangle;

        public CommonAreaCalculate(Triangle triangle) => this.triangle = triangle;

        public double CalculateArea()
        {
            double p;
            // Half of perimeter.
            p = (triangle.A + triangle.B + triangle.C) / 2;
            return Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C)).Round();
        }
    }
}
