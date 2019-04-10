using System;

namespace GeradorAbobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nGerador de Abobrinha");
            Console.WriteLine("Escreve uma palavra aí cz");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 8;

            string[,] palavrasUsuario = new string[maxPalavrasUsuario];

            for (int i=0; maxPalavrasUsuario > 0;i++)
            {
                palavrasUsuario[i] = Console.ReadLine();
                if (--maxPalavrasUsuario != 0)//vai diminuindo(tirando 1) e ve se é diferente de zero
                {
                    Console.WriteLine($"Faltam {maxPalavrasUsuario}. Digite mais uma!");
                }else
                {
                    Console.WriteLine("Agr vem cum o pai q cê passa de ano");
                }
            }
        }
    }
}
