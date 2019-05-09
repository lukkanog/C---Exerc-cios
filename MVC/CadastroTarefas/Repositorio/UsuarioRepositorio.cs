using System;
using System.Collections.Generic;
using System.IO;
using CadastroTarefas.ViewModel;

namespace CadastroTarefas.Repositorio
{
    public class UsuarioRepositorio
    {

        public UsuarioViewModel Inserir(UsuarioViewModel usuario)
        {
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            int contador = 0;
            if (listaDeUsuarios != null)
            {
                contador = listaDeUsuarios.Count;
                usuario.Id = contador + 1;
            }
            usuario.DataCriacao = DateTime.Now;

            StreamWriter sw = new StreamWriter("usuarios.csv",true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.TipoUsuario};{usuario.Email};{usuario.Senha};{usuario.DataCriacao}");
            sw.Close();

            return usuario;
        }
    
        
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

                usuarioViewModel = new UsuarioViewModel();
                usuarioViewModel.Id = int.Parse(dadosDeCadaUsuario[0]);
                usuarioViewModel.Nome = dadosDeCadaUsuario[1];
                usuarioViewModel.TipoUsuario = dadosDeCadaUsuario[2];
                usuarioViewModel.Email = dadosDeCadaUsuario[3];
                usuarioViewModel.Senha = dadosDeCadaUsuario[4];
                usuarioViewModel.DataCriacao = DateTime.Parse(dadosDeCadaUsuario[5]);
                listaDeUsuarios.Add(usuarioViewModel);
            }
            return listaDeUsuarios;
        }// end Listar()
        public UsuarioViewModel BuscarUsuario(string email, string senha)
        {
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            foreach (var item in listaDeUsuarios)
            {
                if (item.Email.Equals(email) && item.Senha.Equals(senha))
                {
                    return item;
                }
            }
            return null;
        }
    }
}