using System;

namespace Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa1, pessoa2;

            pessoa1 = new Pessoas();

            pessoa2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Dados da segunda pessoa: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade == pessoa2.Idade)
            {
                Console.WriteLine("{0} tem a mesma idade de {1}", pessoa1.Nome, pessoa2.Nome);
            }

            else if(pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("{0} é mais velha que {1}", pessoa1.Nome, pessoa2.Nome);
            }

            else
            {
                Console.WriteLine("{0} é mais velha que {1}", pessoa2.Nome, pessoa1.Nome);
            }

        }
    }
}