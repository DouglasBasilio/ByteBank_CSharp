using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();
            c1.titular = "Douglas";
            c1.agencia = 188;
            c1.numero = 188966;
            c1.saldo = 100.0;

            Console.WriteLine("Titular: " + c1.titular);
            Console.WriteLine("AG: " + c1.agencia);
            Console.WriteLine("CC: " + c1.numero);
            Console.WriteLine("Saldo: " + c1.saldo);

            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine();

            ContaCorrente c2 = new ContaCorrente();
            c2.titular = "Jenifer";
            c2.agencia = 288;
            c2.numero = 288966;
            c2.saldo = 200.0;

            Console.WriteLine("Titular: " + c2.titular);
            Console.WriteLine("AG: " + c2.agencia);
            Console.WriteLine("CC: " + c2.numero);
            Console.WriteLine("Saldo: " + c2.saldo);

            Console.ReadLine();
        }
    }
}
