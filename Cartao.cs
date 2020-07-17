using System;

namespace Abstracao_08
{
    public class Cartao : Pagamento
    {
        public string titular {get;set;}
        public int numero {get;set;}
        public string cvc {get;set;}
        public string bandeira {get;set;}
        public string token {get;set;}

         public bool ValidarToken(){
            if (token != null)
            {
                return true;}

                return false;  

        }
    }
}