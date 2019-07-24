namespace ShoppingWebsite
{
    public class PaymentMethodDetails
    {
        public bool confirmationStatus = false, paymentReceiptStatus = false;
        public UserDetails userDetails;
        public string paymentMethod;
        public PaymentMethodDetails(UserDetails userDetails, string paymentMethod)
        {
            this.userDetails = userDetails;
            this.paymentMethod = paymentMethod;
        }

        public PaymentMethodDetails()
        {

        }

    }
}

