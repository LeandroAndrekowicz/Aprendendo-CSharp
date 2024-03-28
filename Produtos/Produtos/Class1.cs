using System;
using System.Globalization;

namespace Produto
{
    internal class Produto
    {
        public string Nome;
        public double Valor;
        public int Quantidade;

        public double ValorTotal()
        {
            double total = Valor * Quantidade;

            return total;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Valor.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade 
                + " unidades, Total: $ " 
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture) ;
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
