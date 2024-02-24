using System;
namespace LLD_Design_Principles.ISP.Violated
{
    public class SQLDatabaseClient: IDatabaseClient
    {
        public SQLDatabaseClient()
        {
        }

        public void Read()
        {
            Console.WriteLine("I have reading capability");
        }

        public void Write()
        {
            Console.WriteLine("I have writing capability");
        }
    }
}

