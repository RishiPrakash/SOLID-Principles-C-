using System;
namespace LLD_Design_Principles.ISP.Violated
{
    /**
     * Ideally in API layer also we have a parametrized constructor
     * which takes an interface of Service layer, and in service also we have (as we have here)
     * a parametrized constructor which can then depend on multiple dependencies like IDatabaseClient here
     * 
     * In Prod env, we have this dependancy fulfilled with DI Container of .NET
     */
    public class ISPViolatedAPI
    {
        private readonly Service _serviceWithSql;
        private readonly Service _serviceWithReports;
        public ISPViolatedAPI()
        {
            _serviceWithSql = new Service(new SQLDatabaseClient());
            _serviceWithReports = new Service(new ReportsClient());
        }

        public void Execute() {
           _serviceWithSql.InteractWithData();
           _serviceWithReports.InteractWithData();
        }

    }
}

