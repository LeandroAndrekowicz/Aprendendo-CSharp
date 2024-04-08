using System.Globalization;

namespace Construtores
{
    internal class Produto
    {
        private string _nome;
        public double Valor
        {
            get;
            private set;
        }
        public int Quantidade
        {
            get;
            private set;
        }

        public Produto()
        {
        }

        public Produto(string nome, double valor, int quantidade)
        {
            _nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotal()
        {
            double total = Valor * Quantidade;

            return total;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionaTotal(int add)
        {
            Quantidade += add;
        }

        public void SubtraiTotal(int sub)
        {
            Quantidade -= sub;
        }
    }
}
