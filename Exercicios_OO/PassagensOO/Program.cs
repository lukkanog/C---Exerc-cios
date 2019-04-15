using System;

namespace PassagensOO
{
    class Program
    {
        static void Main(string[] args)
        {

            int resposta;
            int passageirosCadastrados=0;
            int avioessCadastradas=0;
            Passageiro[] passageiros = new Passageiro[2];
            avioes[] avioes = new avioes[2];

            Console.WriteLine("\nBEM VINDO A FULANO's COMPANIA AÉREA");

                do{
                Console.WriteLine("\nMENU");
                Console.WriteLine("1 - Registrar passagem");
                Console.WriteLine("2 - Visualizar passagens");
                Console.WriteLine("3 - Cadastrar avião");
                Console.WriteLine("4 - Visualizar aviões");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Qual a opção desejada?");
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do passageiro");
                        Passageiro p = new Passageiro();//TODAS AS INFORMAÇÕES VAO FICA AQUI
                        p.setNome(Console.ReadLine());

                        passageiros[passageirosCadastrados] = p;

                        Console.WriteLine("Digite o n° da passagem:");
                        p.setNumeroPassagem(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Digite a data do vôo");
                        p.setData(DateTime.Parse(Console.ReadLine()));
                        
                        passageirosCadastrados++;

                        System.Console.WriteLine("\nPassageiro cadastrado com sucesso");
                        break;

                    case 2:
                           Console.WriteLine("Todos os passageiros cadastrados:");
                       foreach (var passageiro in passageiros)
                       {
                           if (passageiro != null)
                           {
                           Console.WriteLine("========================");
                           Console.WriteLine("Nome do passageiro:");
                           Console.WriteLine(passageiro.getNome ());
                           Console.WriteLine("Numero do vôo:");
                           Console.WriteLine(passageiro.getNumeroPassagem());
                           Console.WriteLine("Data do vôo:");
                           Console.WriteLine(passageiro.getData());
                           }
                       }
                        break;
                    
                    case 3:
                        Console.WriteLine("Modelo da avioes:");
                        Aeronave avioes = new Aeronave();
                        avioes.setModelo(Console.ReadLine());
                        Console.WriteLine("Digite a capacidade máxima de passageiros da avioes:");
                        avioes.setCapacidade(short.Parse(Console.ReadLine()));
                        Console.WriteLine("Digite a quantidade de passageiros:");
                        avioes.setQuantPassageiros(short.Parse(Console.ReadLine()));
                        Console.WriteLine("avioes registrada com sucesso!");
                        avioessCadastradas++;
                        break;

                    case 4:
                        foreach (var aviao in avioes)
                       {
                           if (aviao != null)
                           {
                           Console.WriteLine("========================");
                           Console.WriteLine("Modelo do avião::");
                           Console.WriteLine(aviao.getModelo ());
                           Console.WriteLine("Quantidade de passageiros registrados:");
                           Console.WriteLine(aviao.getQuantPassageiros());
                           Console.WriteLine("Capacidade de passageiros:");
                           Console.WriteLine(aviao.getCapacidade());
                           }
                       }
                        break;

                    case 0:
                        Console.WriteLine("Obrigado pela preferência, volte sempre!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }//end switch
                } while(resposta != 0);
        }
    }
}
