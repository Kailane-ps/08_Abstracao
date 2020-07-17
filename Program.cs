using System;

namespace Abstracao_08
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 1200;

            Console.WriteLine($"Quanto quer acrescentar ?");
            float acres = float.Parse(Console.ReadLine());

            visa.AumentarLimite(acres);
            Console.WriteLine( $"O novo limete é R$:{visa.limite}");


            Console.WriteLine("Digite a data de Pagamento");
            visa.data = DateTime.Parse (Console.ReadLine());
            Console.WriteLine($"A data de pagamento: {visa.data}");

        }
    }
}
