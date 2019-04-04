using System;

namespace BaladaAplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int data;
            int idadeMinima;
            string entrada;


            Console.WriteLine("Balada Calculator\n");
            Console.WriteLine("Que dia é a balada?");
            data = int.Parse(Console.ReadLine().ToLower());

            if (data == 5 || data == 7 || data == 18 || data == 29)
            {
                Console.WriteLine("Você não vai nessa balada porque estará ocupado nesse dia");
            }else
            {
                Console.WriteLine("Qual a idade mínima?");
                idadeMinima = int.Parse(Console.ReadLine().ToLower());

                if (idadeMinima > 16)
                {
                    Console.WriteLine("Você não tem idade suficiente pra essa balada");
                }else
                {
                    Console.WriteLine("Você tem VIP ou já pagou a entrada?");
                    entrada = Console.ReadLine().ToLower();

                    if (entrada.Equals("sim") || entrada.Equals("paguei") || entrada.Equals("tenho vip") || entrada.Equals("paguei a entrada"))
                    {
                        Console.WriteLine("SEXTOOOU");
                    }else
                    {
                        Console.WriteLine("Compre a entrada ou arrume VIP para entrar");
                    }
                }
            }

        }
    }
}
