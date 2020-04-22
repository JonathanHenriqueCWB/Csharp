using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03.Model
{
    class Retangulo
    {
        public double ValorBase { get; set; }
        public double ValorLateral { get; set; }

        public double CalcularArea(Retangulo retangulo)
        {
            return ValorBase*ValorLateral;
        }
        public double CalcularPerimetro(Retangulo retangulo)
        {
            return ((ValorBase * 2) + (ValorLateral * 2));
        }
        public double CalcularDiagonal(Retangulo retangulo)
        {
            // d2= b2+h2
            return Math.Sqrt(ValorBase * ValorBase + ValorLateral * ValorLateral);
        }
    }
}
