using System;
namespace LLD_Design_Principles.ISP.Violated
{
    public interface IDatabaseClient
    {
        void Read();
        void Write();
    }
}

