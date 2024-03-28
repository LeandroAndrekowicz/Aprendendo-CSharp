using System;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int add = int.Parse(Console.ReadLine());
            p.AdicionaTotal(add);

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            int sub = int.Parse(Console.ReadLine());
            p.SubtraiTotal(sub);

            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}