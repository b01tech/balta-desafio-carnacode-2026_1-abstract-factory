using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.PagSeguro;

internal class PagSeguroLogger : IPaymentLogger
{
    public void LogPayment(string processMessage) => Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {processMessage}");
}
