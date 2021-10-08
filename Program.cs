using System;

namespace banco_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta n1 = new Conta(TipoConta.PessoaFisica, "Marcio", 0, 0);
           

            Console.WriteLine(n1);
        }
    }
}
