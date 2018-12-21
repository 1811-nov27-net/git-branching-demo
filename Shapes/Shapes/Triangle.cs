namespace Shapes
{
    public class Triangle
    {
        public double sideA { set; get; }
        public double sideB { set; get; }
        public double sideC { set; get; }
        public double perimeter { get; set; }

        public void SetSides(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.perimeter = sideA + sideB + sideC;

        }
    }
}
