using System;
namespace LLD_Design_Principles.LSP.Compliant_Example
{
    public class LSP_Compliant
    {
        /**
         * To fix this, both parent and child should be enforced to have same behaviour
         * To enforce a behaviour we can use Interface, both parent and child shoudl 
         * implement an Interface, obviously in this case, Interace becomes a parent, and other two
         * become child of it.
         */

        /*
         We are calling the same set of methods to create rectangle and square
         */
        public void Execute()
        {
            var rectangle = new Rectangle();
            rectangle.SetHeight(10);
            rectangle.SetWidth(10);

            var square = new Square();
            square.SetHeight(5);
            square.SetWidth(5);

            var user = new User();
            Console.WriteLine(user.CalculateArea(rectangle));
            Console.WriteLine(user.CalculateArea(square));
        }
    }
}

