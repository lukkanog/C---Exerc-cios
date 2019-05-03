using System;
using System.Collections.Generic;
using CadastroTarefas.ViewModel;

namespace CadastroTarefas.Repositorio
{
    public class TarefaRepositorio
    {
        public static List<TarefaViewModel> listaDeTarefas = new List<TarefaViewModel>();
        public TarefaViewModel NovaTarefa(TarefaViewModel tarefa)
        {
            tarefa.Id = listaDeTarefas.Count +1;
            tarefa.DataCriacao = DateTime.Now;
            listaDeTarefas.Add(tarefa);
            return tarefa;
        }
    
        public static void Listar()
        {
            if (listaDeTarefas.Count == 0)
            {
                Console.WriteLine("\nAinda não há tarefas cadastradas no programa.");
            }

            foreach (TarefaViewModel item in listaDeTarefas)
            {       
                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"ID: {item.Id}");
                    Console.WriteLine($"Tarefa: {item.Nome}");
                    Console.WriteLine($"Descrição: {item.Descricao}");
                    Console.WriteLine($"Status: {item.Tipo}");
                    Console.WriteLine($"Criado em: {item.DataCriacao}");
                    Console.WriteLine($"ID do usuário que criou a tarefa: {item.IdUsuario}");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    // return item;
            }
                    // return null;
        }//Listar()

    
        public void Remover(int id)
        {   
            if (id <= 0 || id >listaDeTarefas.Count)
            {
                Console.WriteLine("\nTarefa não encontrada");
            }  else{
                listaDeTarefas.RemoveAt(id - 1);
                Console.WriteLine($"\nA tarefa {id} foi removida com sucesso");
            }   
            
        }
    }
}