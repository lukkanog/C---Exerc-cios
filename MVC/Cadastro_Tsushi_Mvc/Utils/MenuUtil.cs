using System;

namespace Cadastro_Tsushi_Mvc.Utils
{
    public class MenuUtil
    {
        /// <summary>Exibe as opções do usuário deslogado</summary>
        public static void  MenuDeslogado()
        {
            Console.WriteLine("--------------------------");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("{---------TSUSHI---------}");
            Console.ResetColor();
            Console.WriteLine("| 1 - Cadastrar usuário  |");
            Console.WriteLine("| 2 - Login              |");
            Console.WriteLine("| 3 - Listar usuários    |");
            Console.WriteLine("| 0 - Sair               |");
            Console.WriteLine("|------------------------|");
            Console.WriteLine("|  Escolha uma opção     |");
            Console.WriteLine("|------------------------|");

        }
    
        public static void MenuLogado()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("|    Tsushi - Menu de funcionários  |");
            Console.WriteLine("|      ~~~~~~~~~~~~~~~~~~~~~~~      |");
            Console.WriteLine("|  1 - Cadastrar Produto            |");
            Console.WriteLine("|  2 - Listar produtos              |");
            Console.WriteLine("|  3 - Buscar produto por ID        |");
            Console.WriteLine("|  0 - Retornar ao menu de Login    |");
            Console.WriteLine("=====================================");
            Console.Write("Qual a opção desejada? ");
        }
    }
}