using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposito = 0;
            double saque = 0;

            Console.Write("Entre com o número da Conta: ");
            int conta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial? ( s / n ) : ");
            char verificador = char.Parse(Console.ReadLine());

            if (verificador == 'S' || verificador == 's')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Banco user1 = new Banco(conta, titular, deposito);

            Console.WriteLine(user1);

            Console.Write("Entre com um valor de depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            user1.AdicionaSaldo(deposito);

            Console.WriteLine(user1);

            Console.Write("Entre com o valor de saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            user1.SubtraiSaldo(saque);

            Console.WriteLine(user1);
        }
    }
}