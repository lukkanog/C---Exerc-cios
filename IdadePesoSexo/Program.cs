using System;

namespace IdadePesoSexo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            int homens = 0;
            int mulheres = 0;
            int somaIdadeHomens = 0;
            int somaIdadeMulheres = 0;
            float somaPesoHomens = 0f;
            float somaPesoMulheres = 0f;

            for (int i=0;i<10;i++)
            {
                do
                {
                    Console.WriteLine("\nInsira o sexo da pessoa\n(MASCULINO ou FEMININO)");
                    sexo = Console.ReadLine().ToLower();
                    if (sexo != ("masculino") && sexo != ("feminino"))
                    {
                        Console.WriteLine("Opção inválida");
                    }
                }while (!sexo.Equals ("masculino") && !sexo.Equals ("feminino"));
                Console.WriteLine("Insira a idade da pessoa:");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o peso da pessoa:");
                float peso = float.Parse(Console.ReadLine().ToLower());

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
            
            if (homens >0)
            {
            float mediaIdadeHomens = somaIdadeHomens / homens;
            float mediaPesoHomens = somaPesoHomens / homens;
            Console.WriteLine("===================================");
            Console.WriteLine("A quantidade de homens é: "+ homens);
            Console.WriteLine("A média de idade masculina é: "+mediaIdadeHomens);
            Console.WriteLine("A média de peso masculina é: "+ mediaPesoHomens);
            }else
            {
                Console.WriteLine("Nenhum homem foi inscrito");
            }
            if (mulheres >0)
            {
            float mediaIdadeMulheres = somaIdadeMulheres / mulheres;
            float mediaPesoMulheres = somaPesoMulheres / mulheres;
            Console.WriteLine("\nA quantidade de mulheres é: "+ mulheres);
            Console.WriteLine("A média de idade feminina é: "+ mediaIdadeMulheres);
            Console.WriteLine("A média de peso feminina é: "+ mediaPesoMulheres);
            }else
            {
                Console.WriteLine("Nenhuma mulher foi inscrita");
            }

        }//end of the world
    }
}
