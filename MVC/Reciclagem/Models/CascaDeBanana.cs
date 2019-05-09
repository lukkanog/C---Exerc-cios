using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CascaDeBanana : BaseViewModel, IOrganico
    {
        public bool ReciclarOrganico()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; 
            System.Console.WriteLine($"Casca de Banana deve ir para a COMPOSTEIRA");
            Console.ResetColor();
            return true;
        }
    }
}