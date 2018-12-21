namespace Shapes
{
   

   /*
   represents a triangle with a given Base and Height
    */
    public class Triangle
    {
        public int Base;
        public int Height;

        public Triangle(int baset, int height){
            Base = baset;
            Height = height;
        }

        public double Area(){
            return Base * Height * (0.5);
        }


    }
}
