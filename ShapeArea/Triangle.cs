using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeArea
{
    class Triangle : IShapeArea
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }

        private bool ViableTriangle(double Side1, double Side2, double Side3)
        {
            double[] Sides = new[] { Side1, Side2, Side3 };
            if (Sides.Min() <= 0)
                return false;
            var max = Sides.Max();
            if (Sides.Sum() - max > max)
                return true;
            return false;
        }
        public Triangle(double Side1, double Side2, double Side3)
        {
            if (!ViableTriangle(Side1, Side2, Side3))
            {
                this.side1 = 0;
                this.side2 = 0;
                this.side3 = 0;
            }
            else
            {
                this.side1 = Side1;
                this.side2 = Side2;
                this.side3 = Side3;
            }
        }
        public double Area()
        {
            var p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)) ;
        }
    }
}
