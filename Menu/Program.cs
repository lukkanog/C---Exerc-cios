using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            bool repetir = true;

            while (repetir)
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1 - Login");
                Console.WriteLine("2 - Contato");
                Console.WriteLine("3 - Listar comentários");
                Console.WriteLine("9 - Sair");
                Console.WriteLine("\nQual a opção desejada?");
                
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("Você escolheu: Login");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu: Contato");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu: Listar comentários");
                        break;
                    case 9:
                        repetir = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }// fim switch
            }//fim while
        }
    }
}
