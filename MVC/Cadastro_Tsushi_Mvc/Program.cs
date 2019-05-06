using System;
using Cadastro_Tsushi_Mvc.enums;
using Cadastro_Tsushi_Mvc.Utils;
using Cadastro_Tsushi_Mvc.ViewController;
using Cadastro_Tsushi_Mvc.ViewModel;

namespace Cadastro_Tsushi_Mvc
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            int opcaoLogado;
            do
            {
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1:
                        UsuarioViewController.CadastrarUsuario();
                        break;
                    case 2:
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                        if (usuarioRecuperado != null)
                        {
                            MensagemUtil.MostrarMensagem($"\nSeja bem vindo, {usuarioRecuperado.Nome}",MensagemEnum.DESTAQUE);
                            do
                            {
                                MenuUtil.MenuLogado();
                                opcaoLogado = int.Parse(Console.ReadLine());

                                switch (opcaoLogado)
                                {
                                    case 1:
                                        ProdutoViewController.CadastrarProduto();
                                        break;
                                    case 2:
                                        ProdutoViewController.ListarProduto();
                                        break;
                                    case 3:
                                    ProdutoViewController.ProcurarProduto();
                                        break;
                                    case 0:
                                        break;
                                    default:
                                        MensagemUtil.MostrarMensagem("Opção inválida", MensagemEnum.ALERTA);
                                        break;
                                }
                            } while (opcaoLogado != 0);
                        }
                        break;
                    case 3:
                        UsuarioViewController.ListarUsuario();
                        break;
                    case 0:
                        break;
                    default:
                        MensagemUtil.MostrarMensagem("Opção inválida", MensagemEnum.ALERTA);
                        break;
                }
            } while (opcaoDeslogado != 0);
        }
    }
}
