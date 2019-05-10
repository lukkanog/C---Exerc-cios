using System;
using System.Collections.Generic;
using System.IO;
using FinancaDeMesa.ViewModel;

namespace FinancaDeMesa.Repositorios
{
    public class TransacaoRepositorio
    {
        public TransacaoViewModel InserirTransacao(TransacaoViewModel transacao)
        {
            List<TransacaoViewModel> listaDeTransacoes = ListarTransacoes();

            StreamWriter sw = new StreamWriter("transacoes.csv", true);
            sw.WriteLine($"{transacao.Tipo};{transacao.Descricao};{transacao.DataTransacao:dd/MM/yyyy};{transacao.Valor};{transacao.Nome}");
            sw.Close();
            return transacao;
        }

        public  List<TransacaoViewModel> ListarTransacoes()
        {
            List<TransacaoViewModel> listaDeTransacoes = new List<TransacaoViewModel>();
            TransacaoViewModel transacao;

            if (!File.Exists("transacoes.csv"))
            {
                return null;
            }

            string[] transacoes = File.ReadAllLines("transacoes.csv");
            foreach (var item in transacoes)
            {
                if (item != null)
                {
                    string[] dadosCadaTransacao = item.Split(";");
                    transacao = new TransacaoViewModel();
                    transacao.Tipo = dadosCadaTransacao[0];
                    transacao.Descricao = dadosCadaTransacao[1];
                    transacao.DataTransacao = DateTime.Parse(dadosCadaTransacao[2]);
                    transacao.Valor = double.Parse(dadosCadaTransacao[3]);
                    transacao.Nome = dadosCadaTransacao[4];
                    listaDeTransacoes.Add(transacao);

                }
            }
                    return listaDeTransacoes;
        }

    }
}