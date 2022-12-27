namespace AreaCalculator.Shapes
{
    public class Triangle
    {
        private bool? cachedRightTriangle = null;

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public bool ISRightTriangle()
        {
            if (cachedRightTriangle is not null) return (bool)cachedRightTriangle;

            var sides = new double[3] { A, B, C };

            if (sides.Any(side => side < 1)) return false;

            double hypotenuseLenght = sides.Max();
            IEnumerable<double> hypotenuse = sides.Where(side => side == hypotenuseLenght).ToList();
            if (hypotenuse.Count() > 1) return false;

            if (hypotenuseLenght.Sqr() > double.MaxValue) return false;

            var restSides = sides.Except(hypotenuse);

            var summOfCathest = restSides.Aggregate(0.0, (ag, side) => ag + side.Sqr());

            return Math.Abs(hypotenuseLenght.Sqr() - summOfCathest) < 0.0001;
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
