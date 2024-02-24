namespace LLD_Design_Principles.SRP_OCP_DIP.Compliant
{
    /*
    Notification Client is now dependant on INotifier as DI, this fixes DIP Principle for this case

    Now Notification class is dependant on Abstraction of Notifiers and so adding a new Notifier
    won't impact this class. This fixes OCP princple.
     */
    public class NotificationClient
    {
        private readonly INotifier notifier;

        public NotificationClient(INotifier notifier) => this.notifier = notifier;

        public void Notify(string message) {
            this.notifier.Notify(message);
        }
    }
}

