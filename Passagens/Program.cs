using System;

namespace Passagens
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nome = new string[2];
            int[] numeroPassagem = new int[5];
            DateTime[] data = new DateTime[5];  
            int resposta;
            int i=0;
            int j=0;//contador da exibição

            Console.WriteLine("\nBEM VINDO A FULANO's COMPANIA AÉREA");

                do{
                Console.WriteLine("\nMENU");
                Console.WriteLine("1 - Registrar passagem");
                Console.WriteLine("2 - Visualizar passagens");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Qual a opção desejada?");
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        if (i < nome.Length)
                        {
                            Console.WriteLine("Digite o nome do comprador:");
                            nome[i] = Console.ReadLine();
                            Console.WriteLine("Digite o n° da passagem:");
                            numeroPassagem[i] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a data da viagem(dd/mm/aaaa):");
                            data[i] = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Sua passagem foi cadastrada com sucesso!");
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("\nLimite de compra excedido");
                        }
                        break;

                    case 2:
                        j=0;
                        if (nome[j] != null)
                        {
                            for (j=0;j <i;j++)
                            {
                            Console.WriteLine($"\n-----PASSAGEM {j + 1}------");
                            Console.WriteLine($"Comprador: {nome[j]}");
                            Console.WriteLine($"Número da passagem: {numeroPassagem[j]}");
                            Console.WriteLine($"Data do vôo: {data[j]:dd/MM/yyyy}");
                            }
                        }
                        else
                        {
                            // i = 9;
                            Console.WriteLine("\nNenhuma passagem foi registrada.");
                        }//end if

                        break;

                    case 0:
                        Console.WriteLine("Obrigado pela preferência, volte sempre!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }//end switch
                } while(resposta != 0);
        }//END main
    }
}
