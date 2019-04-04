using System;

namespace ParouIMpar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nPar ou Impar!! Deseja jogar? \n(Escreva SIM ou NÃO)");
            string resposta = Console.ReadLine().ToLower();
            Random r = new Random();
            int numeroPc = r.Next(0,10);
            int soma = 0;


            if(resposta.Equals("sim") || resposta.Equals("yes") || resposta.Equals("quero") || resposta.Equals("pdp") || resposta.Equals("ja") || resposta.Equals("s"))
            {
                Console.WriteLine("\nVamos Jogar!");
                Console.WriteLine("Você quer PAR ou IMPAR?");
                string opcao =Console.ReadLine().ToLower();
                

                if (opcao.Equals("par"))
                {
                    Console.WriteLine("Então eu vou de IMPAR!");
                    Console.WriteLine("Escolha um número de 1 a 10:");
                    int numero = int.Parse(Console.ReadLine());
                    soma = numero + numeroPc;

                    if (numero> 10 || numero <= 0)
                    {
                        Console.WriteLine("Número inválido");
                    }
                    else if(soma % 2 == 0){
                        Console.WriteLine("Eu escolhi " + numeroPc);
                        Console.WriteLine("Você ganhou");
                    }else{
                        Console.WriteLine("Eu escolhi " + numeroPc);
                        Console.WriteLine("Eu ganhei! chupa!");
                    }

                }else if(opcao.Equals("impar") || opcao.Equals("ímpar")){
                    Console.WriteLine("Então eu vou de PAR!");
                    Console.WriteLine("Escolha um número de 1 a 10:");
                    int numero = int.Parse(Console.ReadLine());
                    
                    if (numero > 10 || numero <= 0)
                    {
                        Console.WriteLine("Número inválido");
                    } else if(soma % 2 == 1){
                        Console.WriteLine("Eu escolhi " + numeroPc);
                        Console.WriteLine("Você perdeu, chupa!");
                    }else{
                        Console.WriteLine("Eu escolhi " + numeroPc);
                        Console.WriteLine("Você ganhou!");
                    }
                } else{
                    Console.WriteLine("Opção inválida!");
                }
    
            }else{
                Console.WriteLine("Vaza então");
            }
        }
    }
}
