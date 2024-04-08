using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalculaArea()
        {
            double area = Largura * Altura;

            return area;
        }

        public double CalculaPerimetro() 
        {
            double perimetro =  (Largura + Altura) * 2;

            return perimetro;
        }

        public double CalculaDiagonal()
        {
            double diagonal = Math.Sqrt((Largura * Largura) + (Altura * Altura));

            return diagonal;
        }
    }
}
