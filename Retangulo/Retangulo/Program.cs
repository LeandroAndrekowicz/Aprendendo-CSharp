using System;
using System.Globalization;

namespace Calculos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;

            Console.WriteLine("##############################################################");
            Console.WriteLine("######  Digite 1 para calcular a area do Retangulo      ######");
            Console.WriteLine("######  Digite 2 para calcular o salário do Funcionario ######");
            Console.WriteLine("######  Digite 2 para calcular o perimetro do Retangulo ######");
            Console.WriteLine("##############################################################");

            while (continua)
            {
                Console.Write("Digite uma opção");
                int op = int.Parse(Console.ReadLine());

                if(op == 1)
                {
                    Retangulo();
                }
                else if (op == 2)
                {
                    Funcionario();
                }
            }
        }

        static void Retangulo()
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a Largura e Altura do Retângulo:");

            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = ret.CalculaArea();

            double perimetro = ret.CalculaPerimetro();

            double diagonal = ret.CalculaDiagonal();

            Console.WriteLine("Area: " + area.ToString("F2"));
            Console.WriteLine("Perimetro: " + perimetro.ToString("F2"));
            Console.WriteLine("Diagonal: " + diagonal.ToString("F2"));
        }

        static void Funcionario()
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Entre com os dados do Funcionario:");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(func);
        }
    }
}