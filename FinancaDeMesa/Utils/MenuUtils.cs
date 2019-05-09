using System;
using FinancaDeMesa.Enums;

namespace FinancaDeMesa.Utils
{
    public class MenuUtils
    {
        public static void MenuPrincipal()
        {
            var opcoes = Enum.GetNames(typeof (MenuEnum));
            int codigo = 1;
            string barra = "==============================";
            System.Console.WriteLine("       FINANÇA DE MESA        ");
            System.Console.WriteLine("       Seja bem vindo!        ");
            System.Console.WriteLine(barra);
            foreach (var item in opcoes)
            {
                System.Console.WriteLine($" {codigo++} {TratarTituloMenu(item)}");
            }
            System.Console.WriteLine(barra);
            
        }

        public static string TratarTituloMenu (string titulo) 
            {
                return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());
            }
    }
}