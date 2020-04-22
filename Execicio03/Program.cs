using Exercicio03.Model;
using System;
using System.Globalization;

namespace Execicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.Write("Digite o valor da Base: ");
            retangulo.ValorBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite altura: ");
            retangulo.ValorLateral = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(retangulo.CalcularArea(retangulo));
            Console.WriteLine(retangulo.CalcularPerimetro(retangulo));
            Console.WriteLine(retangulo.CalcularDiagonal(retangulo));
        }
    }
}
