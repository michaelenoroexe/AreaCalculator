using AreaCalculator.Calculators;
using AreaCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    // Статический класс, гарантирующий RAII для калькуляторов площади.
    /// <summary>
    /// Creates area calculator and initialized it with shape.
    /// </summary>
    public static class CalculatorFactory
    {
        public static IAreaCalculator GetCircleCalculator(Circle circle) => new CircleCalculator(circle);
    }
}
