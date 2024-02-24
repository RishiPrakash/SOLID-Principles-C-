using System;
namespace LLD_Design_Principles.ISP.Compliant.Database
{
    public class SQLDatabaseClient : IDatabaseClient
    {
        public SQLDatabaseClient()
        {
        }

        public void Read()
        {
            Console.WriteLine("I can read");
        }

        public void Write()
        {
            Console.WriteLine("I Can write also");
        }
    }
}

