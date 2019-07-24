namespace ShoppingWebsite
{
    public class PayTM : IPaymentGateway
    {
        private UserDetails _userDetails;
        public PayTM()
        {
            _userDetails = new UserDetails();
        }

        public UserDetails GetDetails(UserDetails userDetails)
        {
            _userDetails._registeredMobileNumber = userDetails._registeredMobileNumber;
            _userDetails._userName = userDetails._userName;

            return _userDetails;
        }

        public bool GetConfirmation()
        {
            bool _confirmed = true;
            Notifier _confirmNotification = new Notifier("confirmation");
            return _confirmed;
        }

        public bool MakePayment()
        {
            Notifier _paymentReceiptNotification = new Notifier("paymentreceipt");
            return true;
        }
    }
}
