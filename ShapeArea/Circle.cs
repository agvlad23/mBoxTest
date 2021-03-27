using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea
{
    public class Circle : IShapeArea
    {
        double r;
        public Circle(double R)
        {
            r = R;
        }
        public double Area()
        {
            return r * r * Math.PI;
        }
    }
}
