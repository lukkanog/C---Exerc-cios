using System;
using System.Linq;
using Reciclagem.Interfaces;
using Reciclagem.Models;
using Reciclagem.Utils;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {

            int escolha;
            bool querSair = false;
            do
            { 
                Console.Clear();
                MenuUtil.MenuPrincipal();
                escolha = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                switch (escolha)
                {
                    #region LATA
                    case 1:
                        var lixo = Lixos.lixosDicionario[escolha];
                        Type interfaceEncontrada = lixo.GetType().GetInterface("IMetal");
                        ColocarNaLixeira((IMetal)(lixo));
                        
                        break;
                    #endregion
                    #region GARRAFA
                    case 2:
                        lixo = Lixos.lixosDicionario[escolha];
                        interfaceEncontrada = lixo.GetType().GetInterface("IVidro");
                        ColocarNaLixeira((IVidro)(lixo));
                        
                        break;
                    #endregion
                    #region COPO
                    case 3:
                        lixo = Lixos.lixosDicionario[escolha];
                        interfaceEncontrada = lixo.GetType().GetInterface("IPlastico");
                        ColocarNaLixeira((IPlastico)(lixo));
                        
                        break;
                    #endregion
                    #region BANANA
                    case 4:
                        lixo = Lixos.lixosDicionario[escolha];
                        interfaceEncontrada = lixo.GetType().GetInterface("IOrganico");
                        ColocarNaLixeira((IOrganico)(lixo));
                        
                        break;
                    #endregion
                    #region PILHA
                    case 5:
                        lixo = Lixos.lixosDicionario[escolha];
                        interfaceEncontrada = lixo.GetType().GetInterface("IIndefinido");
                        ColocarNaLixeira((IIndefinido)(lixo));
                        break;
                    #endregion
                    #region PAPEL
                    case 6:
                        lixo = Lixos.lixosDicionario[escolha];
                        interfaceEncontrada = lixo.GetType().GetInterface("IPapel");
                        ColocarNaLixeira((IPapel)(lixo));
                        // Reciclar(lixo);
                        
                        break;
                    #endregion
                    #region ELSE
                    case 0:
                        querSair = true;
                        return;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                    #endregion
                }
                Console.WriteLine("Aperte ENTER para voltar ao menu principal");
                Console.ReadLine();
            } while (!querSair);
        }//MAIN
        
        public static void ColocarNaLixeira (IMetal lixo)
        {
            lixo.ReciclarMetal();
        }
        public static void ColocarNaLixeira (IVidro lixo)
        {
            lixo.ReciclarVidro();
        }
        public static void ColocarNaLixeira (IPapel lixo)
        {
            lixo.ReciclarPapel();
        }
        public static void ColocarNaLixeira (IOrganico lixo)
        {
            lixo.ReciclarOrganico();
        }
        public static void ColocarNaLixeira (IIndefinido lixo)
        {
            lixo.ReciclarIndefinido();
        }
        public static void ColocarNaLixeira (IPlastico lixo)
        {
            lixo.ReciclarPlastico();
        }

        // public static void Reciclar(BaseViewModel lixo)
        // {
        //     Type tipoLixo = lixo.GetType().GetInterfaces().FirstOrDefault();

        //     if (typeof (IPapel).Equals(tipoLixo))
        //     {
        //         var lixoConvertido = (IPapel) lixo;
        //         Console.BackgroundColor = ConsoleColor.DarkBlue;
        //         System.Console.WriteLine($"{lixoConvertido.ReciclarPapel()}");
        //         Console.ResetColor();
        //     } else if (typeof (IMetal).Equals(tipoLixo))
        //     {
        //         var lixoConvertido = (IMetal) lixo;
        //         Console.BackgroundColor = ConsoleColor.DarkYellow;
        //         System.Console.WriteLine($"{lixoConvertido.ReciclarMetal()}");
        //         Console.ResetColor();
        //     } else if (typeof (IVidro).Equals(tipoLixo))
        //     {
        //         var lixoConvertido = (IVidro) lixo;
        //         Console.BackgroundColor = ConsoleColor.DarkGreen;
        //         System.Console.WriteLine($"{lixoConvertido.ReciclarVidro()}");
        //         Console.ResetColor();
        //     } else if (typeof (IPlastico).Equals(tipoLixo))
        //     {
        //         var lixoConvertido = (IPlastico) lixo;
        //         Console.BackgroundColor = ConsoleColor.DarkRed;
        //         System.Console.WriteLine($"{lixoConvertido.ReciclarPlastico()}");
        //         Console.ResetColor();
        //     } else if (typeof (IOrganico).Equals(tipoLixo))
        //     {
        //         var lixoConvertido = (IOrganico) lixo;
        //         Console.BackgroundColor = ConsoleColor.DarkBlue;
        //         System.Console.WriteLine($"{lixoConvertido.ReciclarOrganico()}");
        //         Console.ResetColor();
        //     } else if (typeof (IMetal).Equals(tipoLixo))
        //     {
        //         var lixoConvertido = (IIndefinido) lixo;
        //         // Console.BackgroundColor = ConsoleColor.DarkBlue;
        //         System.Console.WriteLine($"{lixoConvertido.ReciclarIndefinido()}");
        //         Console.ResetColor();
        //     }
        // }
    }
}
