using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoDeNascimento;
            int anoAtual;

            Console.WriteLine("EXERCÍCIO 2");
            Console.WriteLine("\nPosso votar esse ano?");
            Console.WriteLine("Em que ano você nasceu?");
            anoDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Em que ano estamos?");
            anoAtual = int.Parse(Console.ReadLine());

            if (anoAtual - anoDeNascimento < 18)
            {
                Console.WriteLine("Você não poderá votar esse ano porque ainda nao completou 18 anos");
            }else
            {
                Console.WriteLine("Você pode votar esse ano!");
            }
        }
    }
}
