using System;
namespace LLD_Design_Principles.ISP.Compliant.Database
{
    public interface IDatabaseClient : IReadClient, IWriteClient
    {
    }
}

