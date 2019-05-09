using System;
using System.Collections.Generic;
using CadastroTarefas.Repositorio;
using CadastroTarefas.Utils;
using CadastroTarefas.ViewModel;

namespace CadastroTarefas.ViewController
{
    public class TarefaViewController
    {
        static TarefaRepositorio tarefaRepositorio = new TarefaRepositorio();
        public static void CadastrarTarefa(UsuarioViewModel usuario)
        {
            string nome,descricao;
            string tipo = "";
            int tipoTarefa;

            do
            {
                Console.WriteLine("\nNome da tarefa:");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Por favor, dê um nome a essa tarefa.");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.WriteLine("\nDescreva essa tarefa:");
                descricao = Console.ReadLine();
                if (string.IsNullOrEmpty(descricao))
                {
                    Console.WriteLine("Por favor, descreva essa tarefa");
                }
            } while (string.IsNullOrEmpty(descricao));
            
            do
            {
                MenuUtil.MenuTipoTarefa();
                tipoTarefa = int.Parse(Console.ReadLine());
            } while (tipoTarefa != 1 && tipoTarefa != 2 && tipoTarefa != 3);

            switch (tipoTarefa)
            {
                case 1:
                    tipo = "A fazer";
                    break;
                case 2:
                    tipo = "Fazendo";
                    break;
                case 3:
                    tipo = "Feito";
                    break;
                default:
                    Console.WriteLine("\nOpção inválida");
                    break;
            }

           TarefaViewModel tarefaViewModel = new TarefaViewModel();
           tarefaViewModel.Nome = nome;
           tarefaViewModel.Descricao = descricao;
           tarefaViewModel.Tipo = tipo;
           tarefaViewModel.IdUsuario = usuario.Id;
           tarefaRepositorio.NovaTarefa(tarefaViewModel);

           Console.WriteLine("\nTarefa cadastrada com sucesso!\n");
        }//CadastrarTarefa()
    
        public static void ListarTarefa(int idUsuario)
        {
            List<TarefaViewModel> listaDeTarefas = tarefaRepositorio.ListarTarefas();
            if (listaDeTarefas.Count == 0)
            {
                Console.WriteLine("Não há tarefas registradas no programa");
            }
            foreach (TarefaViewModel item in listaDeTarefas)
            {
                if (item != null && item.IdUsuario.Equals(idUsuario))
                {
                Console.WriteLine("\n===============================");
                Console.WriteLine($"ID: {item.Id}\nTarefa: {item.Nome}\nDescrição: {item.Descricao}\nStatus: {item.Tipo}\nCriado em :{item.DataCriacao}\nUsuário: {item.IdUsuario}");
                Console.WriteLine("===============================");
                }
            }
            Console.WriteLine("\nAperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
    
        public static void RemoverTarefa()
        {
            int id;
            Console.Write("Digite o ID da tarefa a ser removida: ");
            id = int.Parse(Console.ReadLine());
            tarefaRepositorio.Remover(id); 
        }
    }
}