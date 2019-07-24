using System;
using Xunit;
using ShoppingWebsite;

namespace TestShoppingWebsite
{
    public class TestPayTM
    {
        [Fact]
        public void PaytmTest()
        {
            //Arrange
            UserDetails userDetails;
            PaymentMethodDetails paymentMethodDetails,returnedDetails;

            //Act

            userDetails = new UserDetails();
            userDetails._userName = "Arnaw Gundawar";
            userDetails._registeredMobileNumber = "8975759698";

            string paymentMethod = "paytm";

            paymentMethodDetails = new PaymentMethodDetails(userDetails, paymentMethod);

            PaymentHandler paymentHandler = new PaymentHandler(paymentMethodDetails);

            returnedDetails = paymentHandler.DoPayment();

            paymentMethodDetails.confirmationStatus = true;
            paymentMethodDetails.paymentReceiptStatus = true;

            //Assert
            Assert.Equal(paymentMethodDetails, returnedDetails);
        }
    }
}
