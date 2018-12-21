namespace Shapes
{
    public class Triangle
    {
        // Properties to measure lengths of all sides
        public decimal Side1 { get; set; }
        public decimal Side2 { get; set; }
        public decimal Side3 { get; set; }

        public decimal Hypotenuse { get; set; } => GetHypotenuse(Side1, Side2, Side3);

        // Check that the triangle obeys the rule of "the sum of the lengths of two sides must be greater than the length of the third side"; return 'true' if rule is obeyed, 'false' if not
        public bool IsGoodTriangle()
        {
            if (Side1 + Side2 < Side3 || Side1 + Side3 < Side2 || Side2 + Side3 < Side1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public decimal GetHypotenuse(decimal sideA, decimal sideB, decimal sideC)
        {

        }



    }
}
