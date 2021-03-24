using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente douglas = new Cliente();

            douglas.nome = "Douglas";
            douglas.profissao = "Desenvolvedor C#";
            douglas.cpf = "111.111.111-20";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = douglas;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            conta.titular.nome = "Douglas Basilio";

            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
