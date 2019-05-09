using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Garrafa : BaseViewModel, IVidro
    {
        public bool ReciclarVidro()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine("A Garrafa de cerveja deve ser jogada na lixeira VERDE");
            Console.ResetColor();
            return true;
        }
    }
}