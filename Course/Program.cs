using Course01;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa básico que mostra a área de um triangulo
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Área de x: " + x.CalcularTriangulo());
            Console.WriteLine("Área de y: " + y.CalcularTriangulo());
        }
    }
}
