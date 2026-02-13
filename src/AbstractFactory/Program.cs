// Solução: Usando Abstract Factory para criar gateways de pagamento
using System;
using AbstractFactory.Services;
using AbstractFactory.Services.MercadoPago;
using AbstractFactory.Services.PagSeguro;
using AbstractFactory.Services.Stripe;

namespace DesignPatternChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Pagamentos ===\n");
            const decimal amount = 150.00m;
            const string cardNumber = "1234567890123456";


            var pagSeguroFactory = new PagSeguroFactory();
            var paymentService = new PaymentService(pagSeguroFactory);
            paymentService.ProcessPayment(amount, cardNumber);

            Console.WriteLine();

            var mercadoPagoFactory = new MercadoPagoFactory();
            var mercadoPagoService = new PaymentService(mercadoPagoFactory);
            mercadoPagoService.ProcessPayment(amount, cardNumber);

            Console.WriteLine();

            var stripeFactory = new StripeFactory();
            var stripeService = new PaymentService(stripeFactory);
            stripeService.ProcessPayment(amount, cardNumber);

            Console.WriteLine();
        }
    }
}
