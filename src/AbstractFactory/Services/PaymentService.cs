using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services;

public class PaymentService(IPaymentGatewayFactory paymentGatewayFactory)
{
    private readonly IPaymentGatewayFactory _paymentFactory = paymentGatewayFactory;

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        var processor = _paymentFactory.CreatePaymentProcessor();
        var validator = _paymentFactory.CreatePaymentValidator();
        var logger = _paymentFactory.CreatePaymentLogger();

        if (!validator.ValidateCard(cardNumber))
        {
            logger.LogPayment("Cartão inválido");
            return;
        }

        var processMessage = processor.ProcessTransaction(amount, cardNumber);
        logger.LogPayment($"Transação processada: {processMessage}");
    }
}
