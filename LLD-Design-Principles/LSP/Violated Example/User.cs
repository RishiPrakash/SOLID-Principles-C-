using System;
namespace LLD_Design_Principles.LSP.ViolatedExample
{
    /*
     Here CalculateArea method contains a condition, of what type of object is passed
     This condition is hint that LSP is being violated.
     */
    public class User
    {
        public int CalculateArea(Rectangle rectangle)
        {
            var type = rectangle.GetType().Name;

            if(string.Equals(type, "Rectangle"))
            {
                return rectangle.Height * rectangle.Width;
            }
            else if(string.Equals(type, "Square"))
            {
                var square = ((Square)rectangle);
                return square.side * square.side;
            }
            return -1;
        }
            
    }
}
