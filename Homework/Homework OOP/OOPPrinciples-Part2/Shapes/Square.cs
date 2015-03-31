namespace Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(double radius)
            : base(radius, radius)
        {
            
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.Width * this.Height;
        }
    }
}
