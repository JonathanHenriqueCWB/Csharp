using Course02.View;
using System;
using System.Globalization;

namespace Course02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Construtor, Variaveis e Propriedades
            int opc = 0;
            #endregion

            do
            {
                Console.WriteLine("-- MENU DE APLICAÇÃO --\n\n"
                    + "\t1 - Cadastrar Produto\n"
                    + "\t2 - Remover Produto\n"
                    + "\t3 - Listar Produto\n"
                    + "\t0 - Sair!!!\n");
                opc = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();

                switch (opc)
                {
                    case 1:
                        ProdutoView.RenderizarCadastrar();
                        break;
                    case 2:
                        ProdutoView.RenderizarDeletar();
                        break;
                    case 3:
                        ProdutoView.RendereizarListar();
                        break;
                    default:
                        opc = 0;
                        break;
                }

            } while (opc != 0);
        }
    }
}
