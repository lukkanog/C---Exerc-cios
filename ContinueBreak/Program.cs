using System;

namespace ContinueBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] suspeitos = {"Fulano", "Ciclano", "Culpado", "Beltrano"};

            for (int i=0; i < suspeitos.Length;i++)
            {
                Console.WriteLine("Voce é:");
                if (suspeitos.Equals("Culpado"))
                {
                    break;//VAI PARAR O LOOP PQ JA ACHOU OQ QUERIA
                }
            }
        }
    }
}
