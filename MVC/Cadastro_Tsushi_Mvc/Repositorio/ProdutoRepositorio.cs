using System;
using System.Collections.Generic;
using System.IO;
using Cadastro_Tsushi_Mvc.ViewModel;

namespace Cadastro_Tsushi_Mvc.Repositorio
{
    public class ProdutoRepositorio
    {

        public ProdutoViewModel CadastrarProduto(ProdutoViewModel produto)
        {
            int contador = 0;
            List<ProdutoViewModel> listaDeProdutos = ListarProdutos();
            
            if (listaDeProdutos != null)
            {
                contador = listaDeProdutos.Count;
                produto.Id = contador +1;
            }
            produto.DataCriacao = DateTime.Now;
            listaDeProdutos.Add(produto);

            StreamWriter sw = new StreamWriter("produtos.csv", true);
            sw.WriteLine($"{produto.Id};{produto.Nome};{produto.Categoria};{produto.Descricao};{produto.Preco};{produto.DataCriacao}");
            sw.Close();
            return produto;
        }

        public List<ProdutoViewModel> ListarProdutos()
        {
            List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();
            ProdutoViewModel produtoViewModel;

            if (!File.Exists("produtos.csv"))
            {
                return null;
            }

            string[] produtos = File.ReadAllLines("produtos.csv");
            foreach (var linha in produtos)
            {
                if (linha == null)
                {
                    return null;
                }

                string[] dadosDeCadaProduto = linha.Split(";");
                produtoViewModel = new ProdutoViewModel();
                produtoViewModel.Id = int.Parse(dadosDeCadaProduto[0]);
                produtoViewModel.Nome = dadosDeCadaProduto[1];
                produtoViewModel.Categoria = dadosDeCadaProduto[2];
                produtoViewModel.Descricao = dadosDeCadaProduto[3];
                produtoViewModel.Preco = float.Parse(dadosDeCadaProduto[4]);
                produtoViewModel.DataCriacao = DateTime.Parse(dadosDeCadaProduto[5]);
                listaDeProdutos.Add(produtoViewModel);
            }
            return listaDeProdutos;
        }
    
        public ProdutoViewModel Pesquisar(int id)
        {
            List<ProdutoViewModel> listaDeProdutos = ListarProdutos();
            foreach (var item in listaDeProdutos)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}