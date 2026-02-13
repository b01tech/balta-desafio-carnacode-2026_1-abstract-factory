using src.services.interfaces;

namespace src.services.PagSeguro;

internal class PagSeguroLogger : IPaymentLogger
{
    public void LogPayment(string processMessage) => Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {processMessage}");
}
