using System;
namespace LLD_Design_Principles.ISP.Violated
{
    public class ReportsClient : IDatabaseClient
    {
        /**
         * Let's say we have Datastore where we ingest all of our transactions
         * and this ingestion happen when customers are interacting with the system
         * Later, we want to read out of this datastore to prepare a report about number of txn done by a client/tenant
         * We are only interested in reading data out of this data store while preparing the report.
         * 
         * But as we are taking this ReportsClient as IDatabaseClient we are forced to
         * implement Write() method also.
         * 
         */
        public ReportsClient()
        {
        }

        public void Read()
        {
            Console.WriteLine("I only have reading capabilities");
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}

