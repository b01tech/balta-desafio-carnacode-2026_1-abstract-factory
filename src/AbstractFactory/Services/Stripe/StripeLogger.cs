using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Stripe;

internal class StripeLogger : IPaymentLogger
{
    public void LogPayment(string processMessage) => Console.WriteLine($"[Stripe Log] {DateTime.Now}: {processMessage}");
}
