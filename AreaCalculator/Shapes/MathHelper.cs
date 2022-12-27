namespace AreaCalculator.Shapes
{
    internal static class MathHelper
    {
        public static double Sqr(this double number) => Math.Pow(number, 2);

        public static double Round(this double number) => Math.Round(number, 4);
    }
}
