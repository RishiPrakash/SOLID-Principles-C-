using System;
namespace LLD_Design_Principles.LSP.ViolatedExample
{

    /*
     Here Square is though a subclass of Rectangle
     but it is introduing it's own method i.e. special behaviour to set side property and different methods to set it
    which means it is different from Rectangle
     */

    public class Rectangle
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
    }

    public class Square : Rectangle
    {
        public int side;

        public void setSide(int side)
        {
            this.side = side;
        }

        
    }
}

