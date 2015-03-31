namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            double result = (this.Width * this.Height) / 2.0;

            return result;
        }
    }
}
