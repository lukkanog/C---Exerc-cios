using System;

namespace CadastroTarefas.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado()
        {
            Console.WriteLine("============================");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|        TO DO LIST        |");
            Console.ResetColor();
            Console.WriteLine("|     -----------------    |");
            Console.WriteLine("|   1 - Cadastre - se      |");
            Console.WriteLine("|   2 - Login              |");
            Console.WriteLine("|   0 - Sair               |");
            Console.WriteLine("|                          |");
            Console.WriteLine("============================");
            Console.Write("Qual a opção desejada? ");
        }
    
        public static void MenuTipoUsuario()
        {
            Console.WriteLine("============================");
            Console.WriteLine("|      TIPO DE USUÁRIO     |");
            Console.WriteLine("|   1 - Usuário            |");
            Console.WriteLine("|   2 - Admin              |");
            Console.WriteLine("============================");
        }
    
        public static void MenuLogado()
        {
            Console.WriteLine("==================================");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("|           TO DO LIST           |");
            Console.ResetColor();
            Console.WriteLine("|        -----------------       |");
            Console.WriteLine("|  1 - Cadastrar nova tarefa     |");
            Console.WriteLine("|  2 - Ver Tarefas               |");
            Console.WriteLine("|  3 - Remover Tarefas           |");
            Console.WriteLine("|  0 - Voltar ao menu de Login   |");
            Console.WriteLine("|                                |");
            Console.WriteLine("==================================");
            Console.Write("Qual a opção desejada? ");
        }
    
        public static void MenuTipoTarefa()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("|      STATUS DA TAREFA     |");
            Console.WriteLine("|   1 - A fazer             |");
            Console.WriteLine("|   2 - Fazendo             |");
            Console.WriteLine("|   3 - Feito               |");
            Console.WriteLine("=============================");
        }
    }
}