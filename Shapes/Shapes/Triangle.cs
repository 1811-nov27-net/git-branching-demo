using System;

namespace Shapes
{
    public class Triangle
    {
        public Point point1, point2, point3;
        
        private static double Distance(Point point1, Point point2)
        {
            // Distance formula
            // sqrt( (x2 - x1) ^ 2 + (y2 - y1) ^2)
            double xSquare = (point1.x - point2.x) * (point1.x - point2.x);
            double ySquare = (point1.y - point2.y) * (point1.y - point2.y);

            return Math.Sqrt(xSquare + ySquare);
        }

        public double Perimeter()
        {
            double perimeter = 0.0;
            perimeter += Distance(point1, point2);
            perimeter += Distance(point2, point3);
            perimeter += Distance(point3, point1);
            return perimeter;
        }
    }
}
