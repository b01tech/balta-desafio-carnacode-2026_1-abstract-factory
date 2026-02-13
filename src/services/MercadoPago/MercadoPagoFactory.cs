using src.services.interfaces;

namespace src.services.MercadoPago;

internal class MercadoPagoFactory : IPaymentFactory
{
    public IPaymentProcessor CreatePaymentProcessor() => new MercadoPagoProcessor();
    public IPaymentValidator CreatePaymentValidator() => new MercadoPagoValidator();
    public IPaymentLogger CreatePaymentLogger() => new MercadoPagoLogger();
}
