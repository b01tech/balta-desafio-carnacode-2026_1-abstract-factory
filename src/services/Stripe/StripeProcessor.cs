using src.services.interfaces;

namespace src.services.Stripe;

internal class StripeProcessor : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"Stripe: Processando R$ {amount}...");
        return $"STRIPE-{Guid.CreateVersion7().ToString().Substring(0, 8)}";
    }
}
