using src.services.interfaces;

namespace src.services.Stripe;

internal class StripeValidator : IPaymentValidator
{
    public bool ValidatePayment(string cardNumber)
    {
        if (cardNumber.Length == 16 && cardNumber.StartsWith("4"))
        {
            Console.WriteLine("Stripe: Cartão válido");
            return true;
        }
        Console.WriteLine("Stripe: Cartão inválido");
        return false;
    }
}
