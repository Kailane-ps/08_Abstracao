namespace Abstracao_08
{
    public class CartaoCredito : Cartao
    {
        public float limite {get;set;}

        public void AumentarLimite( float acrescimo){
            token = "123457";

            limite = limite + acrescimo;
        }

       
    }
}