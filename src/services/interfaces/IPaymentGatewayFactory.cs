namespace src.services.interfaces;

public interface IPaymentGatewayFactory
{
    IPaymentProcessor CreatePaymentProcessor();
    IPaymentValidator CreatePaymentValidator();
    IPaymentLogger CreatePaymentLogger();
}
