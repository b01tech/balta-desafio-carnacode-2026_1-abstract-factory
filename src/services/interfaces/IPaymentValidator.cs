namespace src.services.interfaces;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);

}