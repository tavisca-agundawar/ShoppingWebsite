namespace ShoppingWebsite
{
    public class UserDetails
    {
        public string _userName { get; set; }
        public string _registeredMobileNumber { get; set; }
        public string _upiPaymentId { get; set; }
        public string _cardNumber { get; set; }

        public UserDetails()
        {
            _upiPaymentId = "";
            _userName = "";
            _cardNumber = "";
            _registeredMobileNumber = "";
        }
    }
}