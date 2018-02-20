using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Figure, IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return 3.14 * radius * radius;
        }
    }
}
