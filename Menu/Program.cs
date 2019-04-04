using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            bool repetir = true;
            string usuario;
            string bemVindo = "Convidado";

            while (repetir)
            {
                Console.WriteLine("\nBem Vindo, " + bemVindo);
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Login");
                Console.WriteLine("2 - Contato");
                Console.WriteLine("3 - Listar comentários");
                Console.WriteLine("9 - Sair");
                Console.WriteLine("\nQual a opção desejada?");
                
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("\nUsuário:");
                        usuario = Console.ReadLine().ToLower();
                        if (usuario.Equals("lucas"))
                        {
                            Console.WriteLine("Senha:");
                            string senha = Console.ReadLine();
                            if (senha == "123")
                            {
                                bemVindo = usuario;
                                Console.WriteLine("Você Logou");
                            }else
                            {
                                Console.WriteLine("Senha incorreta");
                            }//fim else Senha
                        }else {
                            Console.WriteLine("Usuário inexistente em nosso sistema");
                        }//fim else Usuario
                        break;
                    case 2:
                        Console.WriteLine("\nContatos");
                        Console.WriteLine(" >Robson - 9002 0909");
                        Console.WriteLine(" >Jorge - 0000 0000");
                        Console.WriteLine(" >Yudi - 4002 8922");
                        break;
                    case 3:
                        Console.WriteLine("\nListar comentários");
                        Console.WriteLine("Muito bom nota zero");
                        Console.WriteLine("Como desenvolvedor vc é um ótimo poeta");
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
