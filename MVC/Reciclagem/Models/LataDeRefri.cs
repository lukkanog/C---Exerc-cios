using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class LataDeRefri : BaseViewModel, IMetal
    {
        public bool ReciclarMetal()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("A lata de refri deve ser jogada na lixeira AMARElA");
            Console.ResetColor();
            return true;
        }
    }
}