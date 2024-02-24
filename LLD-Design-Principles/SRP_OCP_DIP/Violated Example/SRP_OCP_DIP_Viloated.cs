namespace LLD_Design_Principles.SRP_OCP_DIP.Violated
{
    public class SRP_OCP_DIP_Viloated
    {
        public static void Execute()
        {
            var notificationClient = new NotificationClient();

            notificationClient.notify("This is a sample message", "Email");
            notificationClient.notify("This is a sample message", "SMS");

        }
    }
}

