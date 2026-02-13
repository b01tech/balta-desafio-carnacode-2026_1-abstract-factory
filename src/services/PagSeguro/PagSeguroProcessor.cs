using src.services.interfaces;

namespace src.services.PagSeguro;

internal class PagSeguroProcessor : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        return $"PAGSEG-{Guid.CreateVersion7().ToString().Substring(0, 8)}";
    }
}
