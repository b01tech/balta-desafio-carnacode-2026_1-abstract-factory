using src.services.interfaces;

namespace src.services;

public class PaymentService(IPaymentFactory paymentFactory)
{
    private readonly IPaymentFactory _paymentFactory = paymentFactory;

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        var processor = _paymentFactory.CreatePaymentProcessor();
        var validator = _paymentFactory.CreatePaymentValidator();
        var logger = _paymentFactory.CreatePaymentLogger();

        if (!validator.ValidatePayment(cardNumber))
        {
            logger.Log("Cartão inválido");
            return;
        }

        var processMessage = processor.ProcessTransaction(amount, cardNumber);
        logger.Log($"Transação processada: {processMessage}");
    }
}
