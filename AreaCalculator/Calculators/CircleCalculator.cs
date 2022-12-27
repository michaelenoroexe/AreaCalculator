using AreaCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Calculators
{
    internal class CircleCalculator : IAreaCalculator
    {
        private Circle circle;

        public CircleCalculator(Circle circle) => this.circle = circle;

        public double GetArea()
        {
            // Можно добавть класс валидации для повторяющихся проверок параметров.
            if (circle.Radius < 0) throw new ArgumentOutOfRangeException("Size of shape is negative");

            double roundedValue = circle.Radius.Round();
            if (roundedValue == 0) throw new ArgumentException("Incorect shape size");

            double result = (Math.PI * roundedValue.Sqr()).Round();

            if (double.IsPositiveInfinity(result)) throw new ArgumentOutOfRangeException("Size of shape is to big");

            return result;
        }
    }
}
