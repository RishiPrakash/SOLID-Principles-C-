using System;
namespace LLD_Design_Principles.ISP.Violated
{
    /**
            * Here we have two database client implementations 1. SQLDatabaseClient 2. ReportsClient
            * 
            * We have exposed read and write method for both of these.
            * 
            * As we have a Consumer method here, we need to wrap this in Try catch, because we might not be sure of
            * which method is implemented and which not.
            * How : as ReportsClient method is not suppose to implement write method, there can be more than one way of doing this
            * 1. Do nothing inside write method
            * 2. throw NotImplementedException
            * 3  throw some custom error
            * 4. throw big fat Error Object
            * 
            * Hence client is not immune to changes in Interfaces - one indication of ISP violation
            * 
            */
    public class Service
    {
        private readonly IDatabaseClient _databaseClient;
        public Service(IDatabaseClient databaseClient)
        {
            _databaseClient = databaseClient;

        }

        public void InteractWithData()
        {
            try
            {
                _databaseClient.Read();
                _databaseClient.Write();
            }
            catch(Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}

