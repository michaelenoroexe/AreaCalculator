using AreaCalculator.Calculators.TriangeCalculationStrategy;
using AreaCalculator.Shapes;

namespace AreaCalculator.Calculators
{
    internal class TriangleCalculator : IAreaCalculator
    {
        private readonly Triangle triangle;

        private static bool IsRightTriangle(double[] sides)
        {
            IEnumerable<double> hypotenuse = sides.Where(side => side == sides.Max());

            var restSides = sides.Except(hypotenuse);
            var summOfCathest = restSides.Aggregate(0.0, (ag, side) => ag + side.Sqr());

            return Math.Abs(hypotenuse.First().Sqr() - summOfCathest) < 0.0001;
        }

        private static TriangeTypes DefineTriangleType(double[] sides)
        {
            if (sides.All(side => side == sides.Max())) return TriangeTypes.Equilateral;

            if (sides[0] == sides[1] ||
                sides[0] == sides[2] ||
                sides[1] == sides[2]) return TriangeTypes.Isosceles;

            if (IsRightTriangle(sides)) return TriangeTypes.Right;

            return TriangeTypes.Common;
        }

        public TriangleCalculator(Triangle triangle) => this.triangle = triangle;

        public double GetArea()
        {
            var sides = new double[3] { triangle.A, triangle.B, triangle.C };

            if (sides.Any(side => side < 0.0)) throw new ArgumentOutOfRangeException("Size of shape is negative");

            if (sides.Any(side => side.Round() == 0.0)) throw new ArgumentException("Incorect shape size");

            IAreaCalculate areaCalculator = DefineTriangleType(sides) switch
            {
                TriangeTypes.Equilateral => new EquilateralAreaCalculate(triangle),
                TriangeTypes.Right => new RightAreaCalculate(triangle),
                _ => new CommonAreaCalculate(triangle),
            };

            double result = areaCalculator.CalculateArea();

            if (double.IsNaN(result)) throw new ArgumentOutOfRangeException("Size of shape is to big");
            if (double.IsPositiveInfinity(result)) throw new ArgumentOutOfRangeException("Size of shape is to big");

            return result;
        }
    }
}
