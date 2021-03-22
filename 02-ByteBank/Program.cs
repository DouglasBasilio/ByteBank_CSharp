using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Douglas";
            Console.WriteLine(conta.titular);

            conta.saldo = 200.0;

            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
