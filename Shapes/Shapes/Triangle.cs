namespace Shapes
{
    public class Triangle
    {
        private float side1;
        private float side2;
        private float side3;

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
    }
}
