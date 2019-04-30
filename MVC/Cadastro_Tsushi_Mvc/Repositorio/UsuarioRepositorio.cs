using System;
using System.Collections.Generic;
using Cadastro_Tsushi_Mvc.ViewModel;

namespace Cadastro_Tsushi_Mvc.Repositorio
{
    public class UsuarioRepositorio
    {
        List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
        public UsuarioViewModel Inserir (UsuarioViewModel usuario)

        {
            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.DataCriacao = DateTime.Now;
            //insere um objeto usuario dentro da lista
            listaDeUsuarios.Add(usuario);
            
            return usuario;
        }
        
        
        /// <summary>Retorna lista de usuários</summary>
        public List<UsuarioViewModel> Listar()
        {
             return listaDeUsuarios;
        }

        /// <summary>Verifica se o usuário é válido</summary>
        /// <param name="email">Email do usuario</param>
        /// <param name="senha">senha do usuário</param>
        /// <returns>Retorna o usuario caso ele seja encontrado ou retorna NULL caso na exista</returns>
        public UsuarioViewModel BuscarUsuario(string email, string senha)
        {
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