namespace MobilePhoneDevice
{
    using System;

    public class Display
    {
        public Display(int displayColor, double displaySize)
        {
            this.Color = displayColor;
            this.Size = displaySize;
        }

        public int Color { get; private set; }

        public double Size { get; private set; }

        public override string ToString()
        {
            return String.Format("Display:\nColors {0,16} colors\nSize {1,18} inches", this.Color, this.Size);
        }
    }
}
