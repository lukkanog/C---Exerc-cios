using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class PilhaUsada : BaseViewModel, IIndefinido
    {
        public bool ReciclarIndefinido()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            System.Console.WriteLine("A pilha usada deve ser encaminhada para o descarte especial");
            Console.ResetColor();
            return true;
        }
    }
}