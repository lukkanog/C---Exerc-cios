using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = {100,50,20,10,5,2,1};
            int saldo;
            int retirar;
            DateTime data = DateTime.Now;

            Console.WriteLine("\n   CAIXA ELETRÔNICO    ");
            Console.WriteLine("=========================");
            Console.WriteLine("Digite o seu saldo atual:");
            saldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor a ser retirado:");
            retirar = int.Parse(Console.ReadLine());

            if(retirar<=saldo)
            {
                for (int i = 0; i< notas.Length;i++)
                {
                    int quantNotas = retirar / notas[i];//quando divide ele n pega a sobra
                    int restante = retirar % notas[i];//o excedente é a sobra
                    retirar = restante;

                    if(quantNotas != 0)
                    {
                        Console.WriteLine($"Você recebeu {quantNotas} nota(s) de {notas[i]} em {data}");
                    }//end if
                }//end FOR
            }//end if
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }//end else
        }
    }
}
