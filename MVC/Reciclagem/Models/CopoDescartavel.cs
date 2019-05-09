using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class CopoDescartavel : BaseViewModel, IPlastico
    {
        public bool ReciclarPlastico()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Copos descartáveis devem ser colocado na lixeira VERMELHA");
            Console.ResetColor();
            return true;
        }
    }
}