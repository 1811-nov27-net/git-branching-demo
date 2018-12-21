using System;

namespace Shapes
{
    public class Triangle
    {
        public double Ax { get; set; }
        public double Ay { get; set; }
        public double Bx { get; set; }
        public double By { get; set; }
        public double Cx { get; set; }
        public double Cy { get; set; }

        public double Perimeter
        {
            get
            {
                return Math.Sqrt((By - Ay) * (By - Ay) + (Bx - Ax) * (Bx - Ax)) +
                    Math.Sqrt((Cy - By) * (Cy - By) + (Cx - Bx) * (Cx - Bx)) +
                    Math.Sqrt((Ay - Cy) * (Ay - Cy) + (Ax - Cx) * (Ax - Cx));
            }
        }
    }
}
