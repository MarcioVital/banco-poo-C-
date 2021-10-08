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

        public override string ToString()
        {
            string retorno = "";
            retorno += this.TipoConta  + "  |  ";
            retorno += this.nome + "  |  ";
            retorno += this.saldo + "  |  ";
            retorno += this.credito + "  |  ";

            return retorno;
        }

        public bool sacar (double valorSaque)
        {
            if (this.saldo - valorSaque < (this.credito * -1))
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }
            this.saldo -= valorSaque;
            Console.WriteLine("{0}, seu Saldo agora é {1}", this.nome, this.saldo);
            return true;
           
        }

        public void Depositar(double valorDeposito)
        {
            this.saldo += valorDeposito;
            Console.WriteLine("{0}, agora seu saldo ficou de R$ {1}", this.nome, this.saldo);

        }

        
        
    }
}
