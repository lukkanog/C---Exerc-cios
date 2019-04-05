using System;

namespace ExFor
{
    class Program
    {
        static void Main(string[] args)
        {

            // for ( int i=0; i<=5; i++)
            // {
            //     Console.WriteLine(i);
            // }

            string estrela="";

            Console.WriteLine("ESCADA MAKER");
            Console.WriteLine("Escreva o tamanho de degraus desejado em  sua escada");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            
            for (int i = 1; i <= quantidade; i++)
            {
            estrela+="*";
            Console.WriteLine(estrela);
            }
        }
    }
}
