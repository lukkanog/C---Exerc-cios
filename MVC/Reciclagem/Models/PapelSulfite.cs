using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class PapelSulfite : BaseViewModel, IPapel
    {
        public bool ReciclarPapel()
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("O papel sulfite deve ser jogado na lixeira AZUL");
            Console.ResetColor();
            return true;
        }
    }
}