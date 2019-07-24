using System;

namespace ShoppingWebsite
{
    public partial class PaymentHandler
    {
        private string _paymentMethod;
        UserDetails _userDetails;

        public PaymentHandler(PaymentMethodDetails paymentMethodDetails)
        {
            _userDetails = paymentMethodDetails.userDetails;
            _paymentMethod = paymentMethodDetails.paymentMethod;
        }
        public PaymentMethodDetails DoPayment()
        {
            PaymentMethodDetails returnedDetails = new PaymentMethodDetails();

            switch (_paymentMethod.ToLowerInvariant())
            {
                case "paytm":
                    PayTM _payTMHandler = new PayTM();
                    returnedDetails.paymentMethod = _paymentMethod;
                    returnedDetails.userDetails = _payTMHandler.GetDetails(_userDetails);
                    returnedDetails.confirmationStatus =_payTMHandler.GetConfirmation();
                    if(returnedDetails.confirmationStatus is true)
                    {
                        returnedDetails.paymentReceiptStatus = _payTMHandler.MakePayment();
                    }
                    return returnedDetails;

                default:
                    break;
            }

            return returnedDetails;
        }
    }
}

