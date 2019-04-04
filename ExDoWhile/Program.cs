using System;

namespace ExDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jaAcordei = false;

            do{
            Console.WriteLine("Você já acordou?");
            string resposta = Console.ReadLine().ToLower();

            jaAcordei = resposta.Contains("yuqe") ? true : false; //O CONTAINS VAI PROCURAR A PALAVRA YUQE DENTRO DA RESPOSTA
            } while (!jaAcordei);
        }
    }
}
