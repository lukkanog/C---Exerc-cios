using System;
using FinancaDeMesa.Enums;
using FinancaDeMesa.Repositorios;
using FinancaDeMesa.Utils;
using FinancaDeMesa.ViewController;
using FinancaDeMesa.ViewModel;
using Spire.Doc;

namespace FinancaDeMesa {
    class Program {
        static void Main (string[] args) {
            bool querSair = false;
            do {
                Console.Clear();
                MenuUtils.MenuPrincipal ();
                System.Console.Write ("Qual a opção desejada?");
                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:
                        UsuarioViewController.CadastrarUsuario ();
                        MensagemUtils.Continuar();
                        break;

                    case 2:
                        UsuarioViewModel usuarioLogado = UsuarioViewController.Login ();
                        if (usuarioLogado != null) {
                            do {
                                Console.Clear();
                                MenuUtils.MenuLogado (usuarioLogado);
                                System.Console.Write ("Qual a opção desejada? ");
                                codigo = int.Parse (Console.ReadLine ());
                               

                                switch (codigo) {
                                    case 1:
                                        TransacaoViewController.CadastrarTransacao (ref usuarioLogado);
                                        MensagemUtils.Continuar();
                                        break;
                                    case 2:
                                        TransacaoViewController.ListarTransacoes (usuarioLogado);
                                        MensagemUtils.Continuar();
                                      
                                        break;
                                    case 3:
                                        UsuarioViewController.Relatorio(usuarioLogado);
                                        MensagemUtils.Continuar();
                                        break;
                                    case 4:
                                        TransacaoRepositorio.ZiparArquivos ();
                                        MensagemUtils.Continuar();
                                        break;
                                    case 5:
                                        break;
                                    default:
                                        MensagemUtils.MostrarMensagem ("Opção inválida", Cores.ALERTA);
                                        MensagemUtils.Continuar();
                                        break;
                                }
                            } while (codigo != 5);
                        } else{
                            MensagemUtils.Continuar();
                        }
                        break;
                    case 3:
                        querSair = true;
                        break;
                    default:
                        MensagemUtils.MostrarMensagem ("Opção inválida", Cores.ALERTA);
                        MensagemUtils.Continuar();
                        break;
                }//switch codigo

            } while (!querSair);
        }
    }
}