using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeArea
{
    public class Triangle : IShapeArea
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
                this.side1 = Side1;
                this.side2 = Side2;
                this.side3 = Side3;
            
        }
        public double Area()
        {
            if (!ViableTriangle(side1, side2, side3))
                return 0;
            else
            {
                var p = (side1 + side2 + side3) / 2;
                return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            }
        }

        public bool IsRight()
        {
            double[] Sides = new[] { side1, side2, side3 };
            var hyp = Sides.Max();
            Sides.Except(new[] { hyp });
            var pif = Sides[0] * Sides[0] + Sides[1] * Sides[1];
            return hyp * hyp == pif ? true : false;
        }
    }
}
