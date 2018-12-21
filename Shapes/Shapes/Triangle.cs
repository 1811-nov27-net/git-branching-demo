namespace Shapes
{
    public class Triangle
    {
        double height;
        double length;

        double CalculateArea(double h, double l)
        {
            return (h * l * 0.5);
        }

        bool IsIsoscelesTriangle(double s1, double s2, double s3)
        {
            if (s1 == s2)
                return true;
            else if (s1 == s3)
                return true;
            else if (s2 == s3)
                return true;
            else
                return false;
        }

        bool IsEquilateralTriangle(double s1, double s2, double s3)
        {
            if (s1 == s2 && s2 == s3)
                return true;
            else
                return false;
        }
    }
}
