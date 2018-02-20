using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class RightTriangle : Figure, IFigure
    {
        private double sideA;
        private double sideB;

        public RightTriangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override double GetArea()
        {
            return 0.5 * sideA * sideB;
        }
    }
}
