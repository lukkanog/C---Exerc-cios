using System;
using System.Collections.Generic;
using System.IO;
using Cadastro_Tsushi_Mvc.ViewModel;

namespace Cadastro_Tsushi_Mvc.Repositorio
{
    public class UsuarioRepositorio
    {
        // List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
        public UsuarioViewModel Inserir (UsuarioViewModel usuario)
        {
            int contador = 0;
            List<UsuarioViewModel> listaDeUsuarios = Listar();

            if (listaDeUsuarios != null)
            {
                contador = listaDeUsuarios.Count;
                usuario.Id = contador +1;
            }
            usuario.DataCriacao = DateTime.Now;
            //insere um objeto usuario dentro da lista
            // listaDeUsuarios.Add(usuario);

            //cria novo arquivo
            StreamWriter sw = new StreamWriter("usuarios.csv",true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao}");
            sw.Close();//fecha o arquivo

            return usuario;
        }
        
        /// <summary>Retorna lista de usuários</summary>
        public  List<UsuarioViewModel> Listar()
        {
            List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
            UsuarioViewModel usuarioViewModel;

            if (!File.Exists("usuarios.csv"))
            {
                return null;
            }
            
            string [] usuarios = File.ReadAllLines("usuarios.csv");
            foreach (var linha in usuarios)
            {
                if (linha == null)
                {
                    return null;
                }//if

                string[] dadosDeCadaUsuario = linha.Split(";");
                //separa os dados de cada usuario em uma array

                usuarioViewModel = new UsuarioViewModel();
                usuarioViewModel.Id = int.Parse(dadosDeCadaUsuario[0]);
                usuarioViewModel.Nome = dadosDeCadaUsuario[1];
                usuarioViewModel.Email = dadosDeCadaUsuario[2];
                usuarioViewModel.Senha = dadosDeCadaUsuario[3];
                usuarioViewModel.DataCriacao = DateTime.Parse(dadosDeCadaUsuario[4]);
                listaDeUsuarios.Add(usuarioViewModel);
            }
            return listaDeUsuarios;
        }// end Listar()

        /// <summary>Verifica se o usuário é válido</summary>
        /// <param name="email">Email do usuario</param>
        /// <param name="senha">senha do usuário</param>
        /// <returns>Retorna o usuario caso ele seja encontrado ou retorna NULL caso na exista</returns>
        public UsuarioViewModel BuscarUsuario(string email, string senha)
        {
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            foreach (var item in listaDeUsuarios)
            {
                if (item.Email.Equals(email) && item.Senha.Equals(senha))
                {
                    return item;
                }
            }//end ForEach
            return null;               
        }//end BuscarUsuario()
    }
}