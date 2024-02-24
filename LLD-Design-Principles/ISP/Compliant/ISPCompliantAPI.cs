using System;
using LLD_Design_Principles.ISP.Compliant.Database;

namespace LLD_Design_Principles.ISP.Compliant
{
    /**
     * Now we have divided the IDatabaseClient Interface into two parts
     * and any client is not forced to implement what it does not want
     * 
     * Also If we kept Service dependant on both the clients, it would have violated 
     * SRP principle, hence we create two different service - one responsible for 
     * SQL related actions while other related to Reports related actions
     * 
     * This cleans the code, and removes any need of try catch block to check for 
     * NotImplementedExceptions
     */
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

