using System;
using System.Globalization;

namespace AreaTriangulo 
{ 
    class AreaTriangulo
    {
        static void Main(string[] args)
        {
            Triangulo.Triangulo x, y;

            x = new Triangulo.Triangulo();

            y = new Triangulo.Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4"));

            Console.WriteLine("Área de Y = " + areaY.ToString("F4"));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }

            else 
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }    
}
