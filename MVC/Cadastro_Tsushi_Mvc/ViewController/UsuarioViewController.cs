using System;
using System.Collections.Generic;
using Cadastro_Tsushi_Mvc.enums;
using Cadastro_Tsushi_Mvc.Repositorio;
using Cadastro_Tsushi_Mvc.Utils;
using Cadastro_Tsushi_Mvc.ViewModel;

namespace Cadastro_Tsushi_Mvc.ViewController
{
    public class UsuarioViewController
    {
        //criar objeto do tipo Usuário
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CadastrarUsuario()
        {
            string nome, email, senha, confirmaSenha;

            do
            {
                Console.WriteLine("\nDigite seu nome:");
                nome = Console.ReadLine().ToUpper();
                if (string.IsNullOrEmpty(nome))
                {
                    MensagemUtil.MostrarMensagem("Nome inválido", MensagemEnum.ERRO);
                }
            } while (string.IsNullOrEmpty(nome));
            
            do
            {
                Console.WriteLine("Digite seu email:");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email))
                {
                    MensagemUtil.MostrarMensagem("Email inválido", MensagemEnum.ERRO);
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                Console.WriteLine("Digite sua nova senha:");
                senha = Console.ReadLine();
                Console.WriteLine("Confirme sua senha:");
                confirmaSenha = Console.ReadLine();
                if (!ValidacaoUtil.ConfirmacaoSenha(senha,confirmaSenha))
                {
                    MensagemUtil.MostrarMensagem("Senha inválida. A senha deve conter no mínimo 8 caracteres e ser igual à confirmação da mesma.", MensagemEnum.ERRO);
                }
            } while ((!ValidacaoUtil.ConfirmacaoSenha(senha,confirmaSenha)));

        UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
        usuarioViewModel.Nome = nome;
        usuarioViewModel.Email = email;
        usuarioViewModel.Senha = senha;

        usuarioRepositorio.Inserir(usuarioViewModel);

        MensagemUtil.MostrarMensagem($"Usuário {usuarioViewModel.Nome} cadastrado com sucesso", MensagemEnum.SUCESSO);
        }//end CadastrarUsuario()    

        public static void ListarUsuario()
        {
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();
            if (listaDeUsuarios.Count == 0)
            {
                MensagemUtil.MostrarMensagem("Ainda não há usuários cadastrados", MensagemEnum.ALERTA);
            }
            foreach (var item in listaDeUsuarios)
            {
                Console.WriteLine("\n====================================");
                Console.WriteLine($"ID: {item.Id}\nNome : {item.Nome}\nEmail: {item.Email}\nCadastro feito em: {item.DataCriacao}");
                Console.WriteLine("======================================");
            }
        }

        public static UsuarioViewModel EfetuarLogin()
        {
            string email;
            string senha;

            do
            {
                System.Console.WriteLine("E-mail:");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email))
                {
                    MensagemUtil.MostrarMensagem("Email inválido", MensagemEnum.ERRO);
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            System.Console.WriteLine("Senha:");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email, senha);
            if (usuarioRecuperado != null)
            {
                return usuarioRecuperado;
            } else
            {
                MensagemUtil.MostrarMensagem("Email ou senha inválidos", MensagemEnum.ERRO);
                return null;
            }
        }//end EfetuarLogin()
    }
}