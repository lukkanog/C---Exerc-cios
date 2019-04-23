using System;

namespace Pizzaria
{
    public class Produto
    {
        static Produto[] arrayDeProduto = new Produto[100];
        static int contador = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCriacao { get; set; }

        public static void CadastrarProduto()
        {
            Console.WriteLine("Nome do produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("Categoria do produto: (Pizza, bebida, porção,etc.)");
            string categoria = Console.ReadLine();
            Console.WriteLine("Descrição do produto:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Valor do produto (em R$):");
            float valor = float.Parse(Console.ReadLine());

            arrayDeProduto[contador] = new Produto();
            arrayDeProduto[contador].Nome = nome;
            arrayDeProduto[contador].Categoria = categoria;
            arrayDeProduto[contador].Descricao = descricao;
            arrayDeProduto[contador].Valor = valor;
            arrayDeProduto[contador].DataCriacao = DateTime.Now;
            arrayDeProduto[contador].Id = contador +1;
            contador ++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Produto cadastrado com sucesso!");
            Console.ResetColor();
        }//end CadastrarProduto

        public static void ListarProdutos()
        {
            foreach (var item in arrayDeProduto)
            {
                if (item != null)
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"ID: {item.Id}");
                    Console.WriteLine($"Nome do produto: {item.Nome}");
                    Console.WriteLine($"Categoria: {item.Categoria}");
                    Console.WriteLine($"Descrição: {item.Descricao}");
                    Console.WriteLine($"Preço: {item.Valor}");
                    Console.WriteLine($"Data de criação: {item.DataCriacao}");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    continue;
                }
                if (contador == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ainda não há produtos cadastrados.\n");
                    Console.ResetColor();
                    break;
                }
            }
        }//ListarProdutos

        public static void Procurar()
        {
            if (contador >0)
            {
                Console.WriteLine("Digite o ID do produto procurado:");
                int idProcurado = int.Parse(Console.ReadLine());
                foreach (var item in arrayDeProduto)
                {
                    if (item != null)
                    {
                        if (idProcurado.Equals(item.Id))
                        {
                            Console.WriteLine($"ID: {item.Id}");
                            Console.WriteLine($"Nome do produto: {item.Nome}");
                            Console.WriteLine($"Categoria: {item.Categoria}");
                            Console.WriteLine($"Descrição: {item.Descricao}");
                            Console.WriteLine($"Preço: {item.Valor}");
                            Console.WriteLine($"Data de criação:{item.DataCriacao}\n");
                        }else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Produto não encontrado.\n");
                            Console.ResetColor();
                            break;
                        }//if
                    }//if
                }//foreach
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ainda não há produtos cadastrados.\n");
                Console.ResetColor();
            }
        }//Procurar()
    }//end of the world
}