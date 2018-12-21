namespace Shapes
{
    public class Triangle
    {
        public struct coords
        {
            public int x, y;

            public coords(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

        public coords[] Trianglecoords { get; set;}

        public int MyProperty { get; set; }

        public double height { get; set; }

        public double base1 { get; set; }

        public double area
        {
            get => 0.5 * (height * base1);
        }


    }
}
