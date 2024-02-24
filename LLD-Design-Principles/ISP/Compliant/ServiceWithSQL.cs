using System;
using LLD_Design_Principles.ISP.Compliant.Database;

namespace LLD_Design_Principles.ISP.Compliant
{
    public class ServiceWithSQL
    {
        private readonly IDatabaseClient _databaseClient;
        public ServiceWithSQL(IDatabaseClient databaseClient)
        {
            _databaseClient = databaseClient;
        }
        public void Execute()
        {
            _databaseClient.Read();
            _databaseClient.Write();

        }
    }
}

