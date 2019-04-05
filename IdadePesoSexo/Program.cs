using System;

namespace IdadePesoSexo
{
    class Program
    {
        static void Main(string[] args)
        {
            int homens = 0;
            int mulheres = 0;
            int somaIdadeHomens = 0;
            int somaIdadeMulheres = 0;
            float somaPesoHomens = 0f;
            float somaPesoMulheres = 0f;

            for (int i=0;i<4;i++)
            {

                Console.WriteLine("\nInsira a idade da pessoa:");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o peso da pessoa:");
                float peso = float.Parse(Console.ReadLine());
                Console.WriteLine("Insira o sexo da pessoa\n(MASCULINO ou FEMININO)");
                string sexo = Console.ReadLine();

                // idade++;

                if ("masculino".Equals(sexo,StringComparison.CurrentCultureIgnoreCase))
                {
                    homens++;
                    somaIdadeHomens+=idade;
                    somaPesoHomens+=peso;
                }else if ("feminino".Equals(sexo,StringComparison.CurrentCultureIgnoreCase))
                {
                    mulheres++;
                    somaIdadeMulheres+=idade;
                    somaPesoMulheres+=peso;
                }else
                {
                    Console.WriteLine("Opção inválida");
                }//end if
            }//end for

            float mediaIdadeHomens = somaIdadeHomens / homens;
            float mediaIdadeMulheres = somaIdadeMulheres / mulheres;

            float mediaPesoHomens = somaPesoHomens / homens;
            float mediaPesoMulheres = somaPesoMulheres / mulheres;

            Console.WriteLine("===================================");
            Console.WriteLine("\nA quantidade de homens é: "+ homens);
            Console.WriteLine("A quantidade de mulheres é: "+ mulheres);

            Console.WriteLine("\nA média de idade masculina é: "+mediaIdadeHomens);
            Console.WriteLine("A média de idade feminina é: "+ mediaIdadeMulheres);

            Console.WriteLine("\nA média de peso masculina é: "+ mediaPesoHomens);
            Console.WriteLine("A média de peso feminina é: "+ mediaPesoMulheres);
        }
    }
}
