using System;
using System.Collections.Generic;

namespace Course02
{
    class ProdutoRepositorio
    {
        private static List<Produto> produtos = new List<Produto>();

        public static List<Produto> Listar()
        {
            return produtos;
        }

        public static void Salvar(Produto produto)
        {
            produtos.Add(produto);
        }

        public static void Remover(Produto produto)
        {
            produtos.Remove(produto);
        }
    }
}
