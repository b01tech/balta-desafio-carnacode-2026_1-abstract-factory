using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.MercadoPago;

internal class MercadoPagoLogger : IPaymentLogger
{
    public void LogPayment(string processMessage) => Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {processMessage}");
}
