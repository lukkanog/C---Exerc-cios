using System;

namespace GeradorAbobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nGerador de Abobrinha");
            Console.WriteLine("Escreve uma palavra aí");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 8;

            string[] palavrasUsuario = new string[maxPalavrasUsuario];

            for (int i=0; maxPalavrasUsuario > 0;i++)
            {
                palavrasUsuario[i] = Console.ReadLine();
                if (--maxPalavrasUsuario != 0)//vai diminuindo(tirando 1) e ve se é diferente de zero
                {
                    Console.WriteLine($"Faltam {maxPalavrasUsuario} palavras. Digite mais uma!");
                }else
                {
                    Console.WriteLine("Agr deixa cmg");
                }
            }

            string[,] matrizPalavras = {
                                            {"o Lula","pia","Neymar","eles",""},
                                            {"gosta de","dança","mexe com ","chora",""},
                                            {"painéis solares","acrílico","pagode","gorilas",""},
                                            {"chorando","queimando máquinas agrícolas","feliz","com um canguru nas costas",""},
                                            {"sempre","ontem","lá na puta que pariu","quando o Palmeiras ganhou um mundial",""}
            };//end matriz

            for (int i=0;i<matrizPalavras.GetLength(0);i++)//pega como referencia o numero q é o tamanho da primeira linha
            {
                for (int j=0; j<matrizPalavras.GetLength(0);j++)
                {
                    if ("".Equals(matrizPalavras[i,j]))
                    {
                        matrizPalavras[i,j] = palavrasUsuario[j];
                    }
                }//end for j                
            }//end for i

            string frase="";
            Random r = new Random();
            for(int i=0;i < matrizPalavras.GetLength(0);i++)
            {

                // frase+=matrizPalavras[r.Next(matrizPalavras.GetLength(0)), 
                // r.Next(matrizPalavras.GetLength(0))]
                // +" ";
            }
            Console.WriteLine($"Sua frase é: {frase}");
        }//END OF THE WORLD
    }
}
