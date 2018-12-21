using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public double GetDistance(Point other)
        {
            return Math.Sqrt((x - other.x) * (x - other.x) + (y - other.y) * (y - other.y) + (z - other.z) * (z - other.z));
        }
    }
}
