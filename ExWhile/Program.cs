using System;

namespace ExWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool usuarioAindaQuerJogar = true;
            int cont = 3;

            while(cont > 0 && usuarioAindaQuerJogar)
            {
            Console.WriteLine("Quer jogar? Quantidade de fichas restantes:" +cont);
            string resposta = Console.ReadLine();
            usuarioAindaQuerJogar = resposta.Equals("sim") ? true : false;
            cont--; //FAZ O CONT IR DIMINUINDO A CADA VEZ / SE FOR CONT++ FAZ ELE AUMENTAR

            }
        }
    }
}
