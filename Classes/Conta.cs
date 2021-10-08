using System;
using System.Collections.Generic;
using System.Text;

namespace banco_poo
{
    class Conta
    {
       private TipoConta TipoConta { get; set; }       
       private string nome { get; set; }
       private double saldo { get; set; }            
       private double credito { get; set; }

       public Conta (TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.TipoConta = TipoConta;
            this.nome = nome;
            this.saldo = saldo;
            this.credito = credito;
        }

        
    }
}
