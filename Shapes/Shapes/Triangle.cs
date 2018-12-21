namespace Shapes
{
    public class Triangle
    {
        public Triangle(Point one, Point two, Point three)
        {
            Vertices = new Point[] { one, two, three};
        }

        Point[] Vertices { get; set; }

        public int GetArea()
        {

        }

    }
}
