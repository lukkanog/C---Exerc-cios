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
                            Console.WriteLine("Digite o nome do passageiro:");
                            nome[i] = Console.ReadLine();
                            Console.WriteLine("Digite o n° da passagem:");
                            numeroPassagem[i] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a data da viagem:");
                            data[i] = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("\nSua passagem foi cadastrada com sucesso!");
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
                            Console.WriteLine($"Passagens registradas: {j+1}");
                            Console.WriteLine($"\n-----PASSAGEM {j + 1}------");
                            Console.WriteLine($"Passageiro: {nome[j]}");
                            Console.WriteLine($"Número da passagem: {numeroPassagem[j]}");
                            Console.WriteLine($"Data do vôo: {data[j]:dd/MMM/yyyy}");//MM MAIUSCULO porque o mm minúsculo é minuto;MMM escreve por extenso o mês
                            }
                        }
                        else
                        {
                            // i = 9;
                            Console.WriteLine("\nNenhuma passagem foi registrada ainda.");
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
