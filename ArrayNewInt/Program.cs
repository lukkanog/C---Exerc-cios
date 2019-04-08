using System;

namespace ArrayNewInt
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[] numeroCasas = new int[5];

            // for (int i=0; i <numeroCasas.Length;i++)
            // {
            //     numeroCasas[i] = int.Parse(Console.ReadLine());
            // }
            // foreach (var numeroCasa in numeroCasas)
            // {
            //     Console.WriteLine($"O número é:{numeroCasa}");
            // }

            int[] numeroCasa = new int[3];
            string[] nome = new string[3];

            for (int i=0; i < numeroCasa.Length;i++)
            {
                Console.WriteLine("\nQual o seu nome?");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Qual o número de sua casa?");
                numeroCasa[i] = int.Parse(Console.ReadLine());
            }
            for (int j=0; j <numeroCasa.Length; j++)
            {
                Console.WriteLine("O número da casa de "+nome[j] +" é "+numeroCasa[j]);
            }
        }
    }
}
