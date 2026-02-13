using src.services.interfaces;

namespace src.services.Stripe;

internal class StripeFactory : IPaymentFactory
{
    public IPaymentProcessor CreatePaymentProcessor() => new StripeProcessor();
    public IPaymentValidator CreatePaymentValidator() => new StripeValidator();
    public IPaymentLogger CreatePaymentLogger() => new StripeLogger();
}
