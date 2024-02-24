namespace LLD_Design_Principles.SRP_OCP_DIP.Violated
{
	/*
	 Notifier class contains more than one reasons to change.
	It can change when we change Email Notifier Or when we change SMS Notifier.
	 */
    public class Notifier
	{
		public void NotifyByEmail(string message) {
			Console.WriteLine(string.Concat(message, " sent by Email"));
		}

		public void NotifyBySMS(string message) {
            Console.WriteLine(string.Concat(message, " sent by SMS"));
        }
	}
}

