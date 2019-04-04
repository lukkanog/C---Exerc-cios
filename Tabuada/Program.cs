using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool repetir = true;

            while (repetir)
            {
            int multiplicador = 0;

            Console.WriteLine("\nTABUADA ONLINE");
            Console.WriteLine("===============//================");
            Console.WriteLine("Escreva o número que você deseja consultar a tabuada:");

            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTABUADA DO " + numero);

                while (multiplicador < 10)
                {
                multiplicador++;
                int resposta = numero * multiplicador;
                Console.WriteLine(numero + "x" + multiplicador + " = " + resposta);
                }

            Console.WriteLine("Deseja consultar a tabuada de outro numero?");
            string continuar = Console.ReadLine().ToLower();
            repetir = continuar.Equals("sim") ? true : false;
            }
        }
    }
}
