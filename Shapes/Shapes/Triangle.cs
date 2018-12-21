using System.Collections.Generic;

namespace Shapes
{
    public class Triangle
    {
        public Triangle(Point one, Point two, Point three)
        {
            Vertices = new Point[] { one, two, three};
        }

        Point[] Vertices { get; set; }

        public double GetArea()
        {
            double Base = Vertices[0].GetDistance(Vertices[1]);

        }

        public IList<int> Sides { get; set; }
        public IList<int> Angles { get; set; }
        public int perimeter { get; set; }
        public double area { get; set; }

        public Triangle(IList<int> sides, IList<int> angles)
        {
            Sides = sides;
            Angles = angles;
            CalculatePerimeter();
        }

        public void CalculatePerimeter()
        {
            perimeter = 0;
            foreach (var side in Sides)
            {
                perimeter += side;
            }
        }

        public void CalculateArea()
        {

        }

    }
}
