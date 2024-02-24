namespace LLD_Design_Principles.SRP_OCP_DIP.Compliant
{
    public class SRP_OCP_DIP_Compliant
    {
        public static void Execute()
        {
            var emailNotifier = new NotificationClient(new EmailNotifier());
            var smsNotifier = new NotificationClient(new SMSNotifier());
            emailNotifier.Notify("This is a sample message");
            smsNotifier.Notify("This is a sample message");
        }
    }
}

