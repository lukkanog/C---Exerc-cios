using System;

namespace mediaAplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1;
            float nota2;
            float nota3;
            int faltas;

            float soma;
          
          

            Console.WriteLine("\nMédia do ano letivo");
            Console.WriteLine("-----------");

            Console.WriteLine("Digite a nota do primeiro bimestre:");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do segundo bimestre:");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do terceiro bimestre");
            nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas do aluno:");
            faltas = int.Parse(Console.ReadLine());
            
            soma = nota1 + nota2 + nota3;
            double media = soma/3;

            Console.WriteLine("\nA soma das notas é: "+soma+"\nE a media é: "+media);

            if (media < 5 || faltas > 25)
            {
                Console.WriteLine("Aluno REPROVADO");
            }else if (media < 9)
            {
                Console.WriteLine("Aluno APROVADO");
            }else
            {
                Console.WriteLine("É isso aí, Jovem!!");
            }
                         
        }
    }
}
