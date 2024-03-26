using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CpfValidator
{
    internal class CpfValidator
    {
        static void Main(string[] args)
        {

            string tempCpf;
            string digito;
            int multiplicador = 2;
            int soma = 0;
            string primeiroVerificador;
            string segundoVerificador;
            bool invalido = false;

            Console.WriteLine("####################################");
            Console.WriteLine("##        CPF Validator           ##");
            Console.WriteLine("####################################");

            Console.WriteLine("\n");

            Console.WriteLine("Digite seu cpf: ");
            string cpf = Console.ReadLine();

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "");

            if( cpf.Length != 11 )
            {
                Console.WriteLine("Cpf eh inválido!");
            }
            else
            {
                tempCpf = cpf.Substring(0, 9);

                for (int i = tempCpf.Length; i-- > 0;)
                {
                    digito = cpf.Substring(i, 1);

                    soma += (Convert.ToInt32(digito) * multiplicador);

                    multiplicador++;
                }

                primeiroVerificador = Convert.ToString(soma % 11);

                if (Convert.ToInt32(primeiroVerificador) < 2)
                {
                    primeiroVerificador = "0";
                }
                else
                {
                    primeiroVerificador = Convert.ToString(11 - Convert.ToInt32(primeiroVerificador));
                }

                if (Convert.ToInt32(cpf.Substring(9, 1)) != Convert.ToInt32(primeiroVerificador))
                {
                    Console.WriteLine("Primeiro digito verificador eh Inválido!");
                    invalido = true;
                }

                tempCpf = cpf.Substring(0, 10);
                soma = 0;
                multiplicador = 2;

                for (int i = tempCpf.Length; i-- > 0;)
                {
                    digito = tempCpf.Substring(i, 1);

                    soma += (Convert.ToInt32(digito) * multiplicador);

                    multiplicador++;
                }

                segundoVerificador = Convert.ToString(soma % 11);

                if (Convert.ToInt32(segundoVerificador) < 2)
                {
                    segundoVerificador = "0";
                }
                else
                {
                    segundoVerificador = Convert.ToString(11 - Convert.ToInt32(segundoVerificador));
                }

                if (Convert.ToInt32(cpf.Substring(10, 1)) != Convert.ToInt32(segundoVerificador))
                {
                    Console.WriteLine("Segundo digito verificador eh Inválido!");
                    invalido = true;
                }

                if (invalido)
                {
                    Console.WriteLine("Cpf informado eh Inválido");
                }
                else
                {
                    Console.WriteLine("Cpf {0} Válido", cpf);
                }
            }


        }
    }
}
