namespace LLD_Design_Principles.SRP_OCP_DIP.Violated
{
    public class SRP_OCP_DIP_Viloated
    {
        private readonly NotificationClient _notificationClient;
        public SRP_OCP_DIP_Viloated() {
            _notificationClient = new NotificationClient();
        }
        public void Execute()
        {
            _notificationClient.notify("This is a sample message", "Email");
            _notificationClient.notify("This is a sample message", "SMS");

        }
    }
}

