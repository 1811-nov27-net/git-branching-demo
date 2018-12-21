using System;
using System.Collections.Generic;

namespace Shapes
{
    public class Triangle
    {
        public Triangle(Point one, Point two, Point three)
        {
            Vertices = new Point[] { one, two, three};
            Sides[0] = one.GetDistance(two);
            Sides[1] = two.GetDistance(three);
            Sides[2] = three.GetDistance(one);


            CalculatePerimeter();
            CalculateArea();
        }

        public Triangle(IList<double> sides, IList<double> angles)
        {
            Sides = sides;
            Angles = angles;
            CalculatePerimeter();
        }

        public IList<double> Sides { get; set; }
        public IList<double> Angles { get; set; }
        public double perimeter { get; set; }
        public double area { get; set; }
        Point[] Vertices { get; set; }

        public void CalculateArea()
        {
            double Base = Vertices[0].GetDistance(Vertices[1]);
            Point Midpoint = Vertices[0].GetMidpoint(Vertices[1]);
            double Height = Midpoint.GetDistance(Vertices[2]);
            area = .5 * Base * Height;
        }

        public void CalculatePerimeter()
        {
            perimeter = 0;
            foreach (var side in Sides)
            {
                perimeter += side;
            }
        }


    }
}
