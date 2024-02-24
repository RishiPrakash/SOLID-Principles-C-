using System;

namespace LLD_Design_Principles.LSP.Compliant_Example
{
    /*
     Here we introduce common methods
    to 1. set height 2. set width 3. calculate area (which was earlier caclulated in User class)
     */
    public interface IShape
    {
        void SetHeight(int height);
        void SetWidth(int width);
        int CalculateArea();
    }

    public class Rectangle : IShape
    {
        public int Height;
        public int Width;

        public void SetHeight(int height)
        {
            this.Height = height;
        }

        public void SetWidth(int width)
        {
            this.Width = width;
        }

        public int CalculateArea()
        {
            return Height * Width;
        }
    }

    public class Square : IShape
    {
        public int Side;

        public void SetHeight(int height)
        {
            this.Side = height;
        }

        public void SetWidth(int width)
        {
            this.Side = width;
        }

        public int CalculateArea()
        {
            return Side * Side;
        }
    }
}
