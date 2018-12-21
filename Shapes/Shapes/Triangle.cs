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

    }
}
