using System;

namespace Abstracao_08
{
    public class Pagamento
    {
        public DateTime data {get;set;}
        public float valor {get;set;}


        public string pagar (float valorPago){
            return "Valor a pagar"+valorPago;
        }

        public string cancelar(){
            return "Cancelar pagamento";
        }
    }
}