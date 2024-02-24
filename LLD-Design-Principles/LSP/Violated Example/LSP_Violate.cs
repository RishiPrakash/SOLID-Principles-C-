using System;
namespace LLD_Design_Principles.LSP.ViolatedExample
{
    /**
     * Liskov Subs Principle - If we subs a Parent object with a child object, this should not break anything!
     * This usually happens when a child introduces it's own special behaviour and
     * to handle that special behaviour in the User/Caller class we need to use
     * If-Else block
     * 
     */

    /*
     To create a rectangle and Square we are needed to call
    different methods. This means we are handling them differently.
     */
    public class LSP_Violate
    {
        public void Execute()
        {
            var rectangle = new Rectangle();
            rectangle.SetHeight(10);
            rectangle.SetWidth(10);

            var square = new Square();
            square.setSide(5);

            var userWithRect = new User();
            Console.WriteLine(userWithRect.CalculateArea(rectangle));

            var userWithSquare = new User();
            Console.WriteLine(userWithSquare.CalculateArea(square));
        }
    }
}

