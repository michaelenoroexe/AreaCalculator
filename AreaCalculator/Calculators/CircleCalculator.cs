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
            throw new NotImplementedException();
        }
    }
}
