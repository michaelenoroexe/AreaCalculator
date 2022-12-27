using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Shapes
{
    public class Circle
    {
        private readonly double radius;
        public double Radius => radius; 

        public Circle(double radius) => this.radius = radius;
    }
}
