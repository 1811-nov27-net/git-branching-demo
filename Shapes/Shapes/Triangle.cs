using System;

namespace Shapes
{
    public class Triangle
    {
        public Point point1, point2, point3;
        double height;
        double length;

        double CalculateArea(double height, double length)
        {
            return (height * length * 0.5);
        }

        bool IsIsoscelesTriangle(Point point1, Point point2, Point point3)
        {
            if (Distance(point1, point2) == Distance(point1, point3))
                return true;
            else if (Distance(point1, point3) == Distance(point2, point3))
                return true;
            else if (Distance(point2, point3) == Distance(point1, point2))
                return true;
            else
                return false;
        }

        bool IsEquilateralTriangle(Point point1, Point point2, Point point3)
        {
            if (Distance(point1, point2) == Distance(point2, point3) && Distance(point2, point3) == Distance(point1, point3))
                return true;
            else
                return false;
        }
        
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
