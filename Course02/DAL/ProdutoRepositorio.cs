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

        public static Produto ProcurarPorNome(Produto p)
        {
            foreach (Produto produtoCadastrado in produtos)
            {
                if (produtoCadastrado.Nome.Equals(p.Nome))
                {
                    return produtoCadastrado;
                }
            }
            return null;
        }

        public static void RemoverProduto(Produto produto)
        {
            produtos.Remove(produto);
        }
    }
}
