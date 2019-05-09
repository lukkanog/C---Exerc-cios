using System;
using System.Collections.Generic;

namespace Reciclagem.Utils
{
    enum FormacaoMenu : uint
    {
        LATA_DE_REFRI,
        GARRAFA,
        COPO_DESCARTAVEL,
        CASCA_DE_BANANA,
        PILHA_USADA,
        PAPEL_SULFITE

    }
    public class MenuUtil
    {
        public static void MenuPrincipal()
        {
            string barra ="~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            System.Console.WriteLine(barra);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("#         RECICLAGEM         #");
            Console.ResetColor();
            System.Console.WriteLine(barra);
            System.Console.WriteLine(" Qual o lixo a ser reciclado? ");
            System.Console.WriteLine(barra);
            System.Console.WriteLine("#  1 - Lata de Refri         #");
            System.Console.WriteLine("#  2 - Garrafa de Cerveja    #");
            System.Console.WriteLine("#  3 - Copo Descartável      #");
            System.Console.WriteLine("#  4 - Casca de Banana       #");
            System.Console.WriteLine("#  5 - Pilha Usada           #");
            System.Console.WriteLine("#  6 - Papel Sulfite         #");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine("#  0 - Sair do programa      #");
            Console.ResetColor();
            System.Console.WriteLine(barra);
        }//end Menuprincipal() 
    }
}