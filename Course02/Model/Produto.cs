using System;
using System.Collections.Generic;
using System.Text;

namespace Course02
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        
        public override string ToString()
        {
            return $"\tNome do produto: {Nome}, Preço do produto: {Preco}, Quantidade do produto {Quantidade} Valor em estoque: {Quantidade * Preco}.";
        }
    }
}
