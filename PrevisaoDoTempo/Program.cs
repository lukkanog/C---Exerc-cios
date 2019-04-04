using System;

namespace PrevisaoDoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            string clima;

            Console.WriteLine("\nSugestão de passeios");
            Console.WriteLine("Como está o clima hoje?");
            clima = Console.ReadLine().ToLower();

            if (clima.Equals("frio")) 
            {
                Console.WriteLine("Vamos à montanha!");
            } 
            else if (clima.Equals("calor"))
            {
                Console.WriteLine("Vamos à praia!");
            } 
            else if (clima.Equals("chuva"))
            {
                Console.WriteLine("Vamos para a Steam?");
                string resposta;
                resposta = Console.ReadLine();

                if (resposta.Equals("sim"))
                {
                    Console.WriteLine("Vamos jogar!");
                } 
                else
                {
                    Console.WriteLine("Vamos para a Netflix!");
                }
            }
            else
            {
                Console.WriteLine("Valor Inválido \nPor favor, digite  um valor igual a Chuva,Calor ou Frio");
            }
        }
    }
}
