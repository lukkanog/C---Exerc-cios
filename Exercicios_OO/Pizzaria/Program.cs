using System;

namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario[] usuarios = new Usuario[2];

            do {
                Console.Clear();
                Console.WriteLine("PIZZARIA");
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Cadastre-se");
                Console.WriteLine("2 - Login");
                Console.WriteLine("3 - Listar usuários");
                Console.WriteLine("9 - Sair");
                Console.Write("Qual a opção desejada?");
                int resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                     Usuario usuario = new Usuario();
                     Console.WriteLine("Qual o seu nome ?");
                     usuario.nome = Console.ReadLine();
                     Console.WriteLine ("Qual o seu E-mail ?");
                     usuario.email = Console.ReadLine();
                     Console.WriteLine("Registre uma senha: ");
                     usuario.senha = Console.ReadLine();
                    break;
                    case 2:
                    break;
                    case 3:
                    break;
                }


            }while(resposta != 9);
        }
    }
}
