using src.services.interfaces;

namespace src.services.MercadoPago;

internal class MercadoPagoLogger : IPaymentLogger
{
    public void LogPayment(string processMessage) => Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {processMessage}");
}
