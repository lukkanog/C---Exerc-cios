using System;
using System.Collections.Generic;
using Cadastro_Tsushi_Mvc.enums;
using Cadastro_Tsushi_Mvc.Repositorio;
using Cadastro_Tsushi_Mvc.Utils;
using Cadastro_Tsushi_Mvc.ViewModel;

namespace Cadastro_Tsushi_Mvc.ViewController
{
    public class ProdutoViewController
    {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        public static void CadastrarProduto()
        {
            string nomeProduto, categoriaProduto, descricaoProduto;
            float preco = 0f;

            do
            {
                Console.WriteLine("Digite o nome do produto:");
                nomeProduto = Console.ReadLine();
                if (string.IsNullOrEmpty(nomeProduto))
                {
                    MensagemUtil.MostrarMensagem("O produto deve ter um nome !!!", MensagemEnum.ALERTA);;
                }
            } while (string.IsNullOrEmpty(nomeProduto));

            do
            {
                Console.WriteLine("Qual a categoria do produto? (exemplo: Prato Principal, Acompanhamento, Bebida)");
                categoriaProduto = Console.ReadLine();
                if (string.IsNullOrEmpty(categoriaProduto))
                {
                    MensagemUtil.MostrarMensagem("Você deve informar a categoria do produto !", MensagemEnum.ALERTA);
                }
            } while (string.IsNullOrEmpty(categoriaProduto));

            do
            {
                Console.WriteLine("Qual a descrição desse produto?");
                descricaoProduto = Console.ReadLine();
                if (string.IsNullOrEmpty(descricaoProduto))
                {
                    MensagemUtil.MostrarMensagem("O produto deve conter uma descrição.", MensagemEnum.ALERTA);
                }
            } while (string.IsNullOrEmpty(descricaoProduto));

            do
            {
                Console.Write("Informe o preço desse produto:\nR$");
                preco = float.Parse(Console.ReadLine());
                if (preco <= 0f)
                {
                    MensagemUtil.MostrarMensagem("O produto deve ter um valor definido", MensagemEnum.ALERTA);
                }
            } while (preco <= 0f);

            ProdutoViewModel produtoViewModel = new ProdutoViewModel();
            produtoViewModel.Nome = nomeProduto;
            produtoViewModel.Categoria = categoriaProduto;
            produtoViewModel.Descricao = descricaoProduto;
            produtoViewModel.Preco = preco;

            produtoRepositorio.CadastrarProduto(produtoViewModel);

            MensagemUtil.MostrarMensagem("\nProduto cadastrado com sucesso",MensagemEnum.SUCESSO);
            
        }//end CadastrarProduto()
    
        public static void ListarProduto()
        {
            List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.ListarProdutos();
            if (listaDeProdutos.Count == 0)
            {
                MensagemUtil.MostrarMensagem("Ainda não há produtos cadastrados", MensagemEnum.ALERTA);
            }
            foreach (ProdutoViewModel item in listaDeProdutos)
            {
                if (item != null)
                {   
                Console.WriteLine("\n===========================");
                Console.WriteLine($"ID: {item.Id}\nProduto : {item.Nome}\nCategoria: {item.Categoria}\nDescrição: {item.Descricao}\nPreço: R${item.Preco}\nCadastro feito em: {item.DataCriacao}");
                Console.WriteLine("===========================");
                }
            }
        }
    
        public static ProdutoViewModel ProcurarProduto()
        {
            int idProcurado;

            Console.WriteLine("Digite o ID do produto procurado:");
            idProcurado = int.Parse(Console.ReadLine());

            ProdutoViewModel produtoProcurado = produtoRepositorio.Pesquisar(idProcurado);

            if (produtoProcurado != null)
            {
                Console.WriteLine("================================");
                Console.WriteLine($"ID: {produtoProcurado.Id}\nProduto : {produtoProcurado.Nome}\nCategoria: {produtoProcurado.Categoria}\nDescrição: {produtoProcurado.Descricao}\nPreço: R${produtoProcurado.Preco}\nCadastro feito em: {produtoProcurado.DataCriacao}");
                Console.WriteLine("================================");
                return produtoProcurado;
            }else
            {
                MensagemUtil.MostrarMensagem("Produto não encontrado", MensagemEnum.ERRO);
                return null;
            }
        }
    }
}