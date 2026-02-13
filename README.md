![CR-1](https://github.com/user-attachments/assets/5b3f4530-df7d-4f27-abe2-4a9259ddf62a)

## 🥁 CarnaCode 2026 - Desafio 01 - Abstract Factory

Oi, eu sou o Bruno e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio

No desafio **Abstract Factory** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:

- ✅ Boas Práticas de Software
- ✅ Código Limpo
- ✅ SOLID
- ✅ Design Patterns (Padrões de Projeto)

## Problema

Uma plataforma de e-commerce precisa integrar com múltiplos gateways de pagamento (PagSeguro, MercadoPago, Stripe) e cada gateway tem componentes específicos (Processador, Validador, Logger).
O código atual está muito acoplado e dificulta a adição de novos gateways.

## Solução

A solução foi implementada utilizando o padrão **Abstract Factory**, garantindo baixo acoplamento e alta coesão.

- **Interfaces Definidas**: Foram criadas interfaces para cada componente (`IPaymentProcessor`, `IPaymentValidator`, `IPaymentLogger`) e para a fábrica (`IPaymentGatewayFactory`).
- **Fábricas Concretas**: Implementação de fábricas específicas para cada gateway (`PagSeguroFactory`, `MercadoPagoFactory`, `StripeFactory`), responsáveis por criar a família de objetos correspondente.
- **Visibilidade**: Interfaces foram definidas como `public` para exposição do contrato, enquanto as implementações concretas foram mantidas como `internal`, encapsulando a complexidade e seguindo boas práticas de design.
- **Modernização**: Atualização da geração de IDs para utilizar `Guid.CreateVersion7()`.

### Exemplo de Uso

```csharp
var mercadoPagoFactory = new MercadoPagoFactory();
var mercadoPagoService = new PaymentService(mercadoPagoFactory);
mercadoPagoService.ProcessPayment(amount, cardNumber);
```

## Sobre o CarnaCode 2026

O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns

Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio

[Repositório Central do Desafio](https://github.com/b01tech/desafio-carnacode-2026-design-patterns.git)
