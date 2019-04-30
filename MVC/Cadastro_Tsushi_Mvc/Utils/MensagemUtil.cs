using System;
using Cadastro_Tsushi_Mvc.enums;

namespace Cadastro_Tsushi_Mvc.Utils
{
    public class MensagemUtil
    {
        public static void MostrarMensagem(string mensagem, MensagemEnum tipoMensagem)
        {
            switch (tipoMensagem)
            {
                case MensagemEnum.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                break;
                case MensagemEnum.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                break;
                case MensagemEnum.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                break;
                case MensagemEnum.DESTAQUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                break;
                default:
                    break;
                
            }
            System.Console.WriteLine(mensagem);
            Console.ResetColor();

            // System.Console.WriteLine("\nAperte ENTER para prosseguir");
            // Console.ReadLine();
        }
    }
}