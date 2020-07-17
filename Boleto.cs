using System;

namespace Abstracao_08
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento {get;set;}
        public string bancoEmissor {get;set;}
        public string codigoDeBarras {get;set;}

        public string registrarNoSistema(){
            return "Resgistrado no Sistema";
        }
        
    }
}