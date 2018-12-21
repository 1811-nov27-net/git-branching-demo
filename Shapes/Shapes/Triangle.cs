using System;

namespace Shapes
{
    public class Triangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public Point point1, point2, point3;

        /// <summary>
        /// Calculate Triagle's area
        /// </summary>
        /// <param name=""></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public float area(float baseSide, float height)
        {
            return (baseSide * height) / 2;
        }

        /// <summary>
        /// Check if TRiagle is equilateral (have 3 sides with same size)
        /// </summary>
        /// <returns></returns>
        public bool IsEquilateral()
        {
            if( Side1 == Side2 && Side1 == Side3)
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

            if (Side1 == Side2 || Side1 == Side3)
                return true;
            return false;
        }

        /// <summary>
        /// Check if Triangle is scalene
        /// </summary>
        /// <returns></returns>
        public bool IsScalene()
        {
            return false;
        }
        

        public double Perimeter()
        {
            double perimeter = 0.0;
            perimeter += Distance(point1, point2);
            perimeter += Distance(point2, point3);
            perimeter += Distance(point3, point1);
            return perimeter;
        }

        private static double Distance(Point point1, Point point2)
        {
            // Distance formula
            // sqrt( (x2 - x1) ^ 2 + (y2 - y1) ^2)
            double xSquare = (point1.x - point2.x) * (point1.x - point2.x);
            double ySquare = (point1.y - point2.y) * (point1.y - point2.y);

            return Math.Sqrt(xSquare + ySquare);
        }

        public double Area()
        {
            var s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }
    }
}
