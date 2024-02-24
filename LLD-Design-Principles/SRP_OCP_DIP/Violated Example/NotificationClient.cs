namespace LLD_Design_Principles.SRP_OCP_DIP.Violated
{
	/*
	 This class has a method which contains multiple
	 reasons to change. This violates SRP

	Also this class is directly dependant on type of notifiers
	ex. Email OR SMS. This means any time a new notifier comes up
	we will modify this class. This violates OCP principle.

	Also this class is directly dependant on low level Notifier Class.
	This violates DIP Principle.
	*/
    public class NotificationClient
    {
		public void notify(string message, string type) {
			var notifier = new Notifier();
			if(String.Equals(type, "Email")){
				notifier.NotifyByEmail(message);
			} else if(String.Equals(type, "SMS")){
				notifier.NotifyBySMS(message);
			}

		}
	}
}

