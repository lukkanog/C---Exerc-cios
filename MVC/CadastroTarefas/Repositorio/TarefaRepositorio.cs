using System;
using System.Collections.Generic;
using System.IO;
using CadastroTarefas.ViewModel;

namespace CadastroTarefas.Repositorio
{
    public class TarefaRepositorio
    {
        public TarefaViewModel NovaTarefa(TarefaViewModel tarefa)
        {
            List<TarefaViewModel> listaDeTarefas = ListarTarefas();
            int contador = 0;

            if (listaDeTarefas != null)
            {
                contador = listaDeTarefas.Count;
                tarefa.Id = listaDeTarefas.Count +1;
            }

            tarefa.DataCriacao = DateTime.Now;

            StreamWriter sw = new StreamWriter("tarefas.csv",true);
            sw.WriteLine($"{tarefa.Id};{tarefa.Nome};{tarefa.Descricao};{tarefa.Tipo};{tarefa.DataCriacao};{tarefa.IdUsuario}");
            sw.Close();

            return tarefa;
        }
    
        public  List<TarefaViewModel> ListarTarefas()
        {
            List<TarefaViewModel> listaDeTarefas = new List<TarefaViewModel>();
            TarefaViewModel tarefaViewModel;

            if (!File.Exists("tarefas.csv"))
            {
                return null;
            }

            string[] tarefas = File.ReadAllLines("tarefas.csv");
            foreach (var linha in tarefas)
            {
                if (linha == null)
                {
                    return null;
                }

                string [] dadosDeCadaTarefa = linha.Split(";");

                tarefaViewModel = new TarefaViewModel();
                tarefaViewModel.Id = int.Parse(dadosDeCadaTarefa[0]);
                tarefaViewModel.Nome = dadosDeCadaTarefa[1];
                tarefaViewModel.Descricao = dadosDeCadaTarefa[2];
                tarefaViewModel.Tipo = dadosDeCadaTarefa[3];
                tarefaViewModel.DataCriacao = DateTime.Parse(dadosDeCadaTarefa[4]);
                tarefaViewModel.IdUsuario = int.Parse(dadosDeCadaTarefa[5]);
                listaDeTarefas.Add(tarefaViewModel);
            }
            return listaDeTarefas;
        }//Listar()

        /// <summary>Apaga a linha de informações no arquivo</summary>
        public void Remover(int id)
        {
            string[] linhas = File.ReadAllLines("tarefas.csv");
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");
                
                if (id.ToString() == linha[0])
                {
                    linhas[i] = "";
                    break;
                }
            }
            File.WriteAllLines("tarefas.csv",linhas);
            
        }//end Remover()
    }
}