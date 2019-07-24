namespace ShoppingWebsite
{
    public interface IPaymentGateway
    {
        UserDetails GetDetails(UserDetails userDetails);
        bool GetConfirmation();

        bool MakePayment();

    }
}
