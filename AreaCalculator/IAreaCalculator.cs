namespace AreaCalculator
{
    public interface IAreaCalculator
    {
        /// <summary>
        /// Calculate area of shape.
        /// </summary>
        /// <returns>Return shapes area with an accuracy of ten thousandths</returns>
        public double GetArea();
    }
}
