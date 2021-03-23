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
            Console.ReadLine();
        }
    }
}
