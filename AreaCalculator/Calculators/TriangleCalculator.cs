using AreaCalculator.Shapes;

namespace AreaCalculator.Calculators
{
    internal class TriangleCalculator : IAreaCalculator
    {
        private readonly Triangle triangle;

        public TriangleCalculator(Triangle triangle) => this.triangle = triangle;

        public double GetArea()
        {
            var sides = new double[3] { triangle.A, triangle.B, triangle.C };

            if (sides.Any(side => side < 0.0)) throw new ArgumentOutOfRangeException("Size of shape is negative");

            if (sides.Any(side => side.Round() == 0.0)) throw new ArgumentException("Incorect shape size");

            double result;
            // Для большей детализации можно заменить на паттерн "Стратегия".
            if (triangle.ISRightTriangle()) result = (0.5 * (triangle.A * triangle.B)).Round();
            else
            {
                double p;
                // Half of perimeter.
                p = (sides.Sum() / 2);
                result = Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C)).Round();
            }
            if (double.IsNaN(result)) throw new ArgumentOutOfRangeException("Size of shape is to big");
            if (double.IsPositiveInfinity(result)) throw new ArgumentOutOfRangeException("Size of shape is to big");

            return result;
        }
    }
}
