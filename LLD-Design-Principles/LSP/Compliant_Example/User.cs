namespace LLD_Design_Principles.LSP.Compliant_Example
{
    /*
     There is no special handling for different shape types - this fixes the LSP
     */
    public class User
    {
        public int CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}

