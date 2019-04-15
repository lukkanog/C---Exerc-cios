using System;

namespace MediaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;

            while (repetir)
            {
                string[] nome = new string[3];
                string[] sobrenome = new string[3];
                float[] nota1 = new float [3];
                float[] nota2 = new float [3];
                float[] media = new float [3];
                string[] resultado = new string[3];
                int quantAprovados = 0;
                int quantReprovados = 0;

                Console.WriteLine("\nCALCULADORA DE MÉDIA");
                Console.WriteLine("Sala:");
                string sala = Console.ReadLine().ToUpper();
                
                for (int i=0;i<nome.Length;i++)
                {
                    Console.WriteLine("=================");
                    Console.WriteLine("Primeiro nome do aluno:");
                    nome[i] = Console.ReadLine();
                    Console.WriteLine("Sobrenome do aluno:");
                    sobrenome[i] = Console.ReadLine();
                    Console.WriteLine("Nota do primeiro semestre:");
                    nota1[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nota do segundo semestre:");
                    nota2[i] = int.Parse(Console.ReadLine());

                    media[i] = (nota1[i] + nota2[i]) / 2; 
                }//end for i

                Console.WriteLine("\nRESULTADOS");
                Console.WriteLine($"SALA: {sala}");

                for (int j=0; j<nome.Length;j++)
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine($"ALUNO: {nome[j]} {sobrenome[j]}");
                    Console.WriteLine($"Média Final:{media[j]}");
                    if (media[j] >=50)
                    {
                        Console.WriteLine("Resultado: APROVADO");
                        quantAprovados++;
                    }else
                    {
                        Console.WriteLine("Resultado: REPROVADO");
                        quantReprovados++;
                    }//end if

                }//end for j
                Console.WriteLine("================================");
                Console.WriteLine($"Quantidade de aprovados: {quantAprovados}");
                Console.WriteLine($"Quantidade de reprovados: {quantReprovados}");
                Console.WriteLine($"\nDeseja registrar as notas de outra sala?");
                string resposta = Console.ReadLine().ToLower();

                if (!resposta.Equals("sim") || resposta.Equals("desejo") || resposta.Equals("quero") || resposta.Equals("s") || resposta.Equals("yes"))
                {
                    repetir = false;
                }//end if
            }//end while
        }
    }
}
