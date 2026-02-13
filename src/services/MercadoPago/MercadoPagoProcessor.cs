using src.services.interfaces;

namespace src.services.MercadoPago;

internal class MercadoPagoProcessor : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"MercadoPago: Processando R$ {amount}...");
        return $"MP-{Guid.CreateVersion7().ToString().Substring(0, 8)}";
    }
}
