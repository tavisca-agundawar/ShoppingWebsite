namespace ShoppingWebsite
{
    public class Notifier
    {
        private string _notificationType;
        private string _notificationMessage;

        public Notifier(string notificationType)
        {
            _notificationType = notificationType;

            switch(_notificationType.ToLowerInvariant())
            {
                case "confirmation":
                    _notificationMessage = "Please confirm your payment.";
                    break;

                case "paymentreceipt":
                    _notificationMessage = "Your payment was confirmed and is now received.";
                    break;

                default:
                    _notificationMessage = "";
                    break;
            }

        }
    }
}