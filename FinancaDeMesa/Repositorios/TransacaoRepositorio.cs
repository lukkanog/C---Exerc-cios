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
        }// ListarTransacoes()

        public void MudarSaldo(UsuarioViewModel usuario, TransacaoViewModel transacao)
        {

            string[] linhas = File.ReadAllLines("usuarios.csv");
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");
                
                if (linha[0].Equals(usuario.Nome))
                {
                    double saldoAntigo = double.Parse(linha[4]);
                    // double novoSaldo;

                    if (transacao.Tipo.Equals("DESPESA"))
                    {
                        usuario.Saldo =  saldoAntigo - transacao.Valor;
                    } else if (transacao.Tipo.Equals("RECEITA"))
                    {
                        usuario.Saldo =  saldoAntigo + transacao.Valor;
                    }


                    linhas[i] = $"{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataDenascimento:dd/MM/yyyy};{usuario.Saldo}";
                    break;
                }
            }
            File.WriteAllLines("usuarios.csv",linhas);
            // StreamWriter sw = new StreamWriter("usuarios.csv",false);
            // sw.WriteLine($"{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataDenascimento:dd/MM/yyyy};{usuario.Saldo}");
            // sw.Close();
        }
    }
}