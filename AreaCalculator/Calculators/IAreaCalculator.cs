using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Calculators
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
