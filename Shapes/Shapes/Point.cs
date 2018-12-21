using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public double GetDistance(Point other)
        {
            return Math.Sqrt((x - other.x) * (x - other.x) + (y - other.y) * (y - other.y) + (z - other.z) * (z - other.z));
        }

        public Point GetMidpoint(Point other)
        {
            Point ret = new Point();
            ret.x = (x + other.x) / 2;
            ret.y = (y + other.y) / 2;
            ret.z = (z + other.z) / 2;


            return ret;
            
        }
    }
}
