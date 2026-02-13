using src.services.interfaces;

namespace src.services.PagSeguro;

internal class PagSeguroFactory : IPaymentFactory
{
    public IPaymentProcessor CreatePaymentProcessor() => new PagSeguroProcessor();
    public IPaymentValidator CreatePaymentValidator() => new PagSeguroValidator();
    public IPaymentLogger CreatePaymentLogger() => new PagSeguroLogger();
}
