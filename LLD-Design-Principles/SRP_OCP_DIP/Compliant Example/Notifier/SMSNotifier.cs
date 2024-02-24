namespace LLD_Design_Principles.SRP_OCP_DIP.Compliant
{
    public class SMSNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine(string.Concat(message, " sent by SMS"));
        }
    }

}

