using System;

namespace Shapes
{
    public class Triangle
    {
        private float side1;
        private float side2;
        private float side3;

        public Point point1, point2, point3;

        /// <summary>
        /// Calculate Triagle's area
        /// </summary>
        /// <param name=""></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public float area(float base, float height)
        {
            return (base * height) / 2;
        }

        /// <summary>
        /// Check if TRiagle is equilateral (have 3 sides with same size)
        /// </summary>
        /// <returns></returns>
        public bool IsEquilateral()
        {
            if( side1 == side2 && side1 == side3)
                return true;
            return false;
        }

        /// <summary>
        /// Check if Triangle is isosceles (2 sides with same size)
        /// </summary>
        /// <returns></returns>
        public bool IsIsosceles()
        {
            if (IsEquilateral())
                return false;

            if (side1 == side2 || side1 == side3)
                return true;
            return false;
        }

        /// <summary>
        /// Check if Triangle is scalene
        /// </summary>
        /// <returns></returns>
        public bool IsScalene()
        {

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
