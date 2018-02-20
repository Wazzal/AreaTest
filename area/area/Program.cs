using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure circle = new Circle(3);
            IFigure triangle = new RightTriangle(4, 6);
            IFigure triangle2 = new Triangle(4, 6, 5);

            Console.WriteLine(circle.GetArea());
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(triangle2.GetArea());
            Console.ReadKey();
        }
    }

    public class Triangle: Figure, IFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public override double GetArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }
}
