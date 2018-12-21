using System.Collections.Generic;

namespace Shapes
{
    public class Triangle
    {
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
