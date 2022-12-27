using AreaCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Calculators
{
    internal class TriangleCalculator : IAreaCalculator
    {
        private readonly Triangle triangle;

        public TriangleCalculator(Triangle triangle) => this.triangle = triangle; 

        public double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
