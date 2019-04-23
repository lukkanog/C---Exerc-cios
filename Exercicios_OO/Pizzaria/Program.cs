using System;

namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("\nBem vindo a Pizzaria do Tsukamoto");
           int escolha = 0;
           do{
               Console.WriteLine("----MENU PRINCIAL----");
               Console.WriteLine("1 -- Cadastrar Usuário");
               Console.WriteLine("2 -- Login");
               Console.WriteLine("3 -- Listar Usuário");
               Console.WriteLine("9 - Sair");
               Console.WriteLine("Qual a opção desejada?");
               escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                         Usuario.Inserir();
                        break;
                    case 2:
                        Usuario.EfetuarLogin();

                        int escolha2;
                        do
                        {
                            Console.WriteLine("~~ MENU DE FUNCIONÁRIOS ~~");
                            Console.WriteLine("1 - Cadastrar produto");
                            Console.WriteLine("2 - Listar produtos");
                            Console.WriteLine("3 - Busca por ID");
                            Console.WriteLine("0 - Retornar ao menu principal");
                            Console.WriteLine("Qual a opção desejada?");
                            escolha2 = int.Parse(Console.ReadLine());

                            switch (escolha2)
                            {
                                case 1:
                                    Produto.CadastrarProduto();
                                    break;
                                case 2:
                                    Produto.ListarProdutos();
                                    break;
                                case 3:
                                    Produto.Procurar();
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }//end switch menu de funcionarios
                        } while (escolha2 != 0);
                        break;
                    case 3:
                        Usuario.Listar();
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }

           }while(escolha != 9);

        
        }
    }
}
