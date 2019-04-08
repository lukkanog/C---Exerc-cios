using System;

namespace ForDuplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int piramides = 3;
            int linhas = 5;

            for (int i=1; i <=piramides; i++)
            {
            string estrela =""; //reseta a piramide
                for (int j =1; j<=linhas; j++) 
                { 
                    estrela+="*";
                    Console.WriteLine(estrela);
                }
            }
        }
    }
}
