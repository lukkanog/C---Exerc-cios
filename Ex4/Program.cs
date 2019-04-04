using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade;

            Console.WriteLine("EXERCÍCIO 4");
            Console.WriteLine("Quantas maçãs foram compradas?");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor total da compra de maçãs é:");

            if (quantidade < 12)
            {
                float resultado1 = quantidade * 0.30f;
                Console.WriteLine("R$"+resultado1);
            }else
            {
                float resultado2 = quantidade * 0.25f;
                Console.WriteLine("R$"+resultado2);
            }

        }
    }
}
