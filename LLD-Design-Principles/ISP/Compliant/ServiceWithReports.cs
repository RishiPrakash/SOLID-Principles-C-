using System;
using LLD_Design_Principles.ISP.Compliant.Database;

namespace LLD_Design_Principles.ISP.Compliant
{
    public class ServiceWithReports
    {
        private readonly IReadClient _readClient;
        public ServiceWithReports(IReadClient readClient)
        {
            _readClient = readClient;
        }

        public void Execute()
        {
            _readClient.Read();
        }
    }
}

