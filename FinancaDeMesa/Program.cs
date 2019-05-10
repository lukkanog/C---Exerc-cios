using System;
using FinancaDeMesa.Enums;
using FinancaDeMesa.Utils;
using FinancaDeMesa.ViewController;
using FinancaDeMesa.ViewModel;

namespace FinancaDeMesa
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            do
            {
                MenuUtils.MenuPrincipal();
                System.Console.Write("Qual a opção desejada?");
                int codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        UsuarioViewController.CadastrarUsuario();
                    break;

                    case 2:
                        UsuarioViewModel usuarioLogado = UsuarioViewController.Login();
                        if (usuarioLogado != null)
                        {
                            do
                            {
                                MenuUtils.MenuLogado(usuarioLogado);
                                System.Console.Write("Qual a opção desejada?");
                                codigo = int.Parse(Console.ReadLine());

                                switch (codigo)
                                {
                                    case 1:
                                        TransacaoViewController.CadastrarTransacao(ref usuarioLogado);
                                    break;
                                    case 2:
                                        TransacaoViewController.ListarTransacoes(usuarioLogado);
                                    break;
                                    case 3:
                                    break;
                                    case 4:
                                    break;
                                    case 5:
                                        querSair = true;
                                    break;
                                    default:
                                        MensagemUtils.MostrarMensagem("Opção inválida",Cores.ALERTA);
                                    break;
                                }
                            } while (!querSair);

                        }
                    break;
                    case 3:
                        querSair = true;
                    break;
                    default:
                        MensagemUtils.MostrarMensagem("Opção inválida",Cores.ALERTA);
                    break;
                }

            } while (!querSair);
        }
    }
}
