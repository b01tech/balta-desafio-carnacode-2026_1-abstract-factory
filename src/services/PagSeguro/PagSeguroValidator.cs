using src.services.interfaces;

namespace src.services.PagSeguro;

internal class PagSeguroValidator : IPaymentValidator
{
    public bool ValidatePayment(string cardNumber)
    {
        if (cardNumber.Length == 16)
        {
            Console.WriteLine("PagSeguro: Cartão válido");
            return true;
        }
        Console.WriteLine("PagSeguro: Cartão inválido");
        return false;
    }
}
