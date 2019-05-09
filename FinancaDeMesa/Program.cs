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
                            MensagemUtils.MostrarMensagem($"Bem vindo,{usuarioLogado.Nome}",Cores.DESTAQUE);
                        }
                    break;
                    default:
                        MensagemUtils.MostrarMensagem("Opção inválida",Cores.ALERTA);
                    break;
                }

            } while (!querSair);
        }
    }
}
