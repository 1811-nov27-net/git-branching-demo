using System;

namespace Shapes
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int Sides => 3;

        public double Area
        {
            get
            {
                var s = (A + B + C) / 2;
                return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            }
        }

        public double Perimeter => A + B + C;
    }
}
