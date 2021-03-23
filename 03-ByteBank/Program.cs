using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();

            c1.titular = "Douglas";
            Console.WriteLine("Saldo anterior: " + c1.saldo);
            c1.Sacar(50);

            Console.WriteLine("Saldo após saque: " + c1.saldo);

            c1.Depositar(500);
            Console.WriteLine("Saldo após depósito: " + c1.saldo);

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();

            ContaCorrente c2 = new ContaCorrente();

            c2.titular = "Jenifer";

            Console.WriteLine("Saldo do Douglas = " + c1.saldo);
            Console.WriteLine("Saldo da Jenifer = " + c2.saldo);

            bool resultadoTransferencia = c1.Transferir(200, c2);

            Console.WriteLine("Saldo do Douglas = " + c1.saldo);
            Console.WriteLine("Saldo da Jenifer = " + c2.saldo);
            Console.WriteLine("Resultado da transferência = " + resultadoTransferencia);

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();

            c2.Transferir(100, c1);

            Console.WriteLine("Saldo do Douglas = " + c1.saldo);
            Console.WriteLine("Saldo da Jenifer = " + c2.saldo);
            Console.WriteLine("Resultado da transferência = " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
