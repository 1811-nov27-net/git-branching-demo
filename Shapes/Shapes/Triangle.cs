using System;

namespace Shapes
{
    public class Triangle
    {
        double height;
        double length;

        double CalculateArea(double h, double l)
        {
            return (h * l * 0.5);
        }

        bool IsIsoscelesTriangle(double s1, double s2, double s3)
        {
            if (s1 == s2)
                return true;
            else if (s1 == s3)
                return true;
            else if (s2 == s3)
                return true;
            else
                return false;
        }

        bool IsEquilateralTriangle(double s1, double s2, double s3)
        {
            if (s1 == s2 && s2 == s3)
                return true;
            else
                return false;
        }
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
