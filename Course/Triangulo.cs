using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course01
{
    public class Triangulo
    {
        public double A, B, C;
        
        public double CalcularTriangulo()
        {
            Console.WriteLine("Entre com as medidas do triangulo: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = (a + b + c) / 2.0;
            area = Math.Sqrt(area * (area - a) * (area - b) * (area - c));
            return area;
        }
    }
}
