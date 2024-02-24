using System;
using LLD_Design_Principles.ISP.Compliant.Database;

namespace LLD_Design_Principles.ISP.Compliant
{
    public class ISPCompliantAPI
    {
        private readonly ServiceWithSQL _serviceWithSQL;
        private readonly ServiceWithReports _serviceWithReports;
        public ISPCompliantAPI()
        {
            _serviceWithSQL = new ServiceWithSQL(new SQLDatabaseClient());
            _serviceWithReports = new ServiceWithReports(new ReportsClient());
        }
        public void Execute()
        {
            _serviceWithSQL.Execute();
            _serviceWithReports.Execute();
            
        }

    }
}

