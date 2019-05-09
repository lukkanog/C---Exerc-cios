using System;
using CadastroTarefas.Repositorio;
using CadastroTarefas.Utils;
using CadastroTarefas.ViewController;
using CadastroTarefas.ViewModel;

namespace CadastroTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            int escolhaLogado;

            Console.Clear();
            do
            {
                MenuUtil.MenuDeslogado();
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        UsuarioViewController.CadastrarUsuario();
                        break;
                    case 2:
                        UsuarioViewModel usuarioTentandoLogar = UsuarioViewController.FazerLogin();
                        if (usuarioTentandoLogar != null)
                        {
                            Console.WriteLine($"\nSeja Bem vindo,{usuarioTentandoLogar.Nome}");

                            do
                            {
                                MenuUtil.MenuLogado();
                                escolhaLogado = int.Parse(Console.ReadLine());

                                switch (escolhaLogado)
                                {
                                    case 1:
                                        TarefaViewController.CadastrarTarefa(usuarioTentandoLogar);
                                        break;
                                    case 2:
                                        TarefaViewController.ListarTarefa(usuarioTentandoLogar.Id);
                                        // usuarioTentandoLogar.Id = 
                                        break;
                                    case 3:
                                        if (usuarioTentandoLogar.TipoUsuario.Equals("USUÁRIO"))
                                        {
                                            Console.WriteLine("\nEssa tarefa só pode ser executada por administradores");
                                        } else 
                                        {
                                            TarefaViewController.RemoverTarefa();
                                        }
                                        break;
                                    case 0:
                                        break;
                                    default:
                                        break;
                                }
                            } while (escolhaLogado != 0);
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }//end switch
            } while (escolha != 0);
        }
    }
}
