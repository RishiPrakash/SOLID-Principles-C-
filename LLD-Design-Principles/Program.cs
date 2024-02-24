using LLD_Design_Principles.ISP.Compliant;
using LLD_Design_Principles.ISP.Violated;
using LLD_Design_Principles.LSP.Compliant_Example;
using LLD_Design_Principles.LSP.ViolatedExample;
using LLD_Design_Principles.SRP_OCP_DIP.Compliant;
using LLD_Design_Principles.SRP_OCP_DIP.Violated;

class Program
{
    static void Main()
    {
        Console.WriteLine("Starting the LLD Design Principles Project");
        // Demonstrate_SRP_OCP_DIP();
        // Demonstrate_LSP();
        Demonstrate_ISP();
        Console.WriteLine("Ending the LLD Design Principles Project");

    }

    public static void Demonstrate_SRP_OCP_DIP() {

        SRP_OCP_DIP_Viloated.Execute();
        SRP_OCP_DIP_Compliant.Execute();
    }

    public static void Demonstrate_LSP()
    {
        LSP_Violate.Execute();
        LSP_Compliant.Execute();
    }

    public static void Demonstrate_ISP() {
        new ISPViolatedAPI().Execute();
        new ISPCompliantAPI().Execute();
    }
}
