using src.services.interfaces;

namespace src.services.MercadoPago;

internal class MercadoPagoValidator : IPaymentValidator
{
    public bool ValidatePayment(string cardNumber)
    {
        if (cardNumber.Length == 16 && cardNumber.StartsWith("5"))
        {
            Console.WriteLine("MercadoPago: Cartão válido");
            return true;
        }
        Console.WriteLine("MercadoPago: Cartão inválido");
        return false;
    }
}
