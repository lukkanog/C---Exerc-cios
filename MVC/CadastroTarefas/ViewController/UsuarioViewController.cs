using System;
using CadastroTarefas.Repositorio;
using CadastroTarefas.Utils;
using CadastroTarefas.ViewModel;

namespace CadastroTarefas.ViewController
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CadastrarUsuario()
        {
            string nome, email, senha, confirmaSenha;
            string tipoUsuario = "";
            int escolhaTipoUsuario;

            do
            {   
                Console.WriteLine("Digite seu nome:");
                nome = Console.ReadLine().ToUpper();
                if (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Nome inválido");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                MenuUtil.MenuTipoUsuario();
                escolhaTipoUsuario = int.Parse(Console.ReadLine());
                switch (escolhaTipoUsuario)
                {
                    case 1:
                        tipoUsuario = "USUÁRIO";
                        break;
                    case 2:
                        tipoUsuario = "ADMINISTRADOR";
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }//switch
            } while (escolhaTipoUsuario != 1 && escolhaTipoUsuario != 2);

            do
            {
                Console.WriteLine("Digite seu email:");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email))
                {
                    Console.WriteLine("Email inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                Console.WriteLine("Digite sua nova senha:");
                senha = Console.ReadLine();
                Console.WriteLine("Confirme sua senha:");
                confirmaSenha = Console.ReadLine();
                if (!ValidacaoUtil.ValidarSenha(senha,confirmaSenha))
                {
                    Console.WriteLine("Senha inválida.");
                }
            } while (!ValidacaoUtil.ValidarSenha(senha,confirmaSenha));

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.TipoUsuario = tipoUsuario;
            usuarioRepositorio.Inserir(usuarioViewModel);

            
            Console.WriteLine($"\nUsuário {usuarioViewModel.Nome} cadastrado com sucesso");
        }//end Cadastrar
    
        public static UsuarioViewModel FazerLogin()
        {
            string email, senha;

            do
            {
                System.Console.Write("E-mail:");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email))
                {
                    Console.WriteLine("E-mail inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            Console.Write("Senha:");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioProcurado = usuarioRepositorio.BuscarUsuario(email,senha);
            if (usuarioProcurado != null)
            {
                return usuarioProcurado;
            }else
            {
                Console.WriteLine("Email ou senha inválidos");
                return null;
            }//if
        }//FazerLogin()
    }
}