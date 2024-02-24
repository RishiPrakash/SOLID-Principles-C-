namespace LLD_Design_Principles.SRP_OCP_DIP.Compliant
{
    public class SRP_OCP_DIP_Compliant
    {
        private readonly NotificationClient _emailNotifier;
        private readonly NotificationClient _smsNotifier;
        public SRP_OCP_DIP_Compliant() {
            _emailNotifier = new NotificationClient(new EmailNotifier());
            _smsNotifier = new NotificationClient(new SMSNotifier());
        }
        public void Execute()
        {
            _emailNotifier.Notify("This is a sample message");
            _smsNotifier.Notify("This is a sample message");
        }
    }
}

