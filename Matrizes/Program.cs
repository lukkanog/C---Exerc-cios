using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix ={
                            {1,2,3},
                            {4,5,6},
                            {7,8,9}
            };// NAO ESQUECE DO PONTO E VIRGULA PQ ESSA MERDA É UMA VARIAVEL
            
            int soma=0;
            for (int i=0; i<matrix.GetLength(0);i++)//i = LARGURA
            {
                for (int j=0; j<matrix.GetLength(0);j++)//j = COLUNA
                {
                    soma += matrix[i,j];
                } //end FORzinho
            }//end for
                    Console.WriteLine($"Soma: {soma}");
        }//END OF THE WORLD
    }
}
