namespace src.services.interfaces;

public interface IPaymentProcessor
{
    string ProcessTransaction(decimal amount, string cardNumber);
}