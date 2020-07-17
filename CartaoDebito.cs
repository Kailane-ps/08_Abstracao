namespace  Abstracao_08
{
    public class CartaoDebito : Cartao
    {
        public int saldo {get;set;}

        public string transferir(float valor){
            return "traferindo Valor"+ valor;
        }

        public string pagarTitulor(){
            return "Pagar Titulo";
        }
    }
}