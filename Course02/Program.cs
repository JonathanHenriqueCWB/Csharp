using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Construtor, Variaveis e Propriedades
            int opc = 0;
            Produto produto;
            #endregion

            do
            {
                Console.WriteLine("-- MENU DE APLICAÇÃO --\n\n"
                    + "\t1 - Cadastrar Produto\n"
                    + "\t2 - Remover Produto\n"
                    + "\t3 - Listar Produto\n"
                    + "\t4 - Valor total em estoque\n"
                    + "\t0 - Sair!!!\n");
                opc = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();

                switch (opc)
                {
                    case 1:
                        #region Cadastrar Produto
                        produto = new Produto();
                        Console.WriteLine("OPÇÃO DE CADASTRO DE PRODUTOS\n");
                        Console.Write("\tDigite nome do produto: ");
                        produto.Nome = Console.ReadLine();
                        Console.Write("\tDigite o preço do produto: ");
                        produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("\tDigite a quantidade do  produto a cadastrar: ");
                        produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
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
                        Console.ReadKey();
                        Console.Clear();
                        #endregion
                        break;
                    case 2:
                        Console.WriteLine("Remover Produto");
                        break;
                    case 3:
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
                        break;
                    case 4:
                        Console.WriteLine("VALOR TOTAL DO ESTOQUE:");
                        break;
                    default:
                        Console.WriteLine("VALOR INVALIDO SAINDO!!!");
                        opc = 0;
                        break;
                }

            } while (opc != 0);
        }
    }
}
