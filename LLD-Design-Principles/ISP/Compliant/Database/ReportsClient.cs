using System;
namespace LLD_Design_Principles.ISP.Compliant.Database
{
    public class ReportsClient : IReadClient
    {
        public ReportsClient()
        {
        }

        public void Read()
        {
            Console.WriteLine("I have the read capability");
        }
    }
}

