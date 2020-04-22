using System;
using System.Globalization;

namespace Course02.View
{
    class ProdutoView
    {
        public static void RenderizarCadastrar()
        {
            #region Cadastrar Produto
            Produto produto = new Produto();
            Console.WriteLine("OPÇÃO DE CADASTRO DE PRODUTOS\n");

            Console.Write("\tDigite nome do produto: ");
            produto.Nome = Console.ReadLine().ToUpper();

            Console.Write("\tDigite o preço do produto: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\tDigite a quantidade do  produto a cadastrar: ");
            produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ProdutoRepositorio.ProcurarPorNome(produto) == null)
            {
                Console.Write(produto + $"\n\nDeseja salvar {produto.Nome} ? (S/N): ");
                string salvar = Console.ReadLine().ToUpper();

                if (salvar == "S")
                {
                    ProdutoRepositorio.Salvar(produto);
                    Console.WriteLine("Salvando seu produto. Pressione qualquer tecla para continuar...");
                }
                else
                {
                    Console.WriteLine("Produto descartado. Pressione qualquer tecla para continuar...");
                }
            }
            else
            {
                Console.WriteLine("\nProduto já se encontra cadastrado!!!");
            }

            Console.ReadKey();
            Console.Clear();
            #endregion
        }
        public static void RenderizarDeletar()
        {
            #region Deletar Produto
            Produto produto = new Produto();

            Console.WriteLine("Digite o nome do produto a ser deletado: ");
            produto.Nome = Console.ReadLine().ToUpper();

            produto = ProdutoRepositorio.ProcurarPorNome(produto);
            if (produto != null)
            {
                ProdutoRepositorio.RemoverProduto(produto);
                Console.WriteLine("Deletando produto: " + produto.Nome);
            }
            else
            {
                Console.WriteLine("Produto não encontrado!!!");
            }

            Console.ReadKey();
            Console.Clear();
            #endregion
        }
        public static void RendereizarListar()
        {
            #region Listar Produtos
            Console.WriteLine("OPÇÃOI DE LISTAGEM DE PRODUTOS\n");
            foreach (var item in ProdutoRepositorio.Listar())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nLista de Produtos. Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
