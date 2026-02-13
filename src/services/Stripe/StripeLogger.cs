using src.services.interfaces;

namespace src.services.Stripe;

internal class StripeLogger : IPaymentLogger
{
    public void LogPayment(string processMessage) => Console.WriteLine($"[Stripe Log] {DateTime.Now}: {processMessage}");
}
