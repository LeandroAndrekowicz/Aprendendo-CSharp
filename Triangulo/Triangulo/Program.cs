using System;
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
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = Area(x.A, x.B, x.C);

            double areaY = Area(y.A, y.B, y.C);

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

        static double Area(double A, double B, double C)
        {
            double p = (A + B + C) / 2;

            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }
    }    
}
