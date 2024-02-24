namespace LLD_Design_Principles.SRP_OCP_DIP.Compliant
{
    /*
     
     Now Low level class like EmailNotifier and SMSNotifier are now dependant on Abstraction
    Also the High level of NotificationClient is dependant on this Abstraction only.
    This fixes DIP Principle.

    Also now Email and SMS Notifiers are separate classes. This fixes SRP for this case.
     */

    public interface INotifier
    {

		void Notify(string message);
	}

}

