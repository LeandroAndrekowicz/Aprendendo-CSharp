using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            double sLiquido = SalarioBruto - Imposto;

            return sLiquido;
        }

        public void AumentaSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem);
        }

        public override string ToString()
        {
            return Nome + ", $" + SalarioLiquido().ToString("F2");
        }
    }
}
