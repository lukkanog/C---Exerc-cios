using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;
            int senhaCorreta = 1234;

            Console.WriteLine("EXERCÍCIO 3");
            Console.WriteLine("Informe sua senha:");
            senha = int.Parse(Console.ReadLine());

            if (senha == senhaCorreta)
            {
                Console.WriteLine("ACESSO PERMITIDO");
            }else
            {
                Console.WriteLine("ACESSO NEGADO");
            }
        }
    }
}
