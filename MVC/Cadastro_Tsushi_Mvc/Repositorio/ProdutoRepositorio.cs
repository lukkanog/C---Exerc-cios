using System;
using System.Collections.Generic;
using Cadastro_Tsushi_Mvc.ViewModel;

namespace Cadastro_Tsushi_Mvc.Repositorio
{
    public class ProdutoRepositorio
    {
        List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();

        public ProdutoViewModel CadastrarProduto(ProdutoViewModel produto)
        {
            produto.Id = listaDeProdutos.Count + 1;
            produto.DataCriacao = DateTime.Now;
            listaDeProdutos.Add(produto);
            return produto;
        }

        public List<ProdutoViewModel> ListarProdutos()
        {
            return listaDeProdutos;
        }
    
        public ProdutoViewModel Pesquisar(int id)
        {
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