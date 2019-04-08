using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = {100,50,20,10,5,2,};
            int saldo;
            int retirar;

            Console.WriteLine("\n   CAIXA ELETRÔNICO    ");
            Console.WriteLine("=========================");
            Console.WriteLine("Digite o seu saldo atual:");
            ;saldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor a ser retirado:");
            retirar = int.Parse(Console.ReadLine());
            if(retirar<=saldo)
            {
                for(int i=0;i <notas.Length;i++)
                {
                    // retirar % notas[i] = 0
                }
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
        }
    }
}
