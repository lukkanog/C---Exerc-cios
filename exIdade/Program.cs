using System;

namespace exIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiores = 0;
            int menores = 0;

            for (int i = 0; i<10;i++) // VAI ACONTECER O QUE ESTA DENTRO DO FOR DEZ VEZES
            {
                Console.WriteLine("Digite a idade:");
                int idade = int.Parse(Console.ReadLine());

                if (idade >=18)
                {
                    maiores++;//SE A IDADE FOR MAIOR QUE 18, A INT MAIORES VAI AUMENTANDO, POR ISSO DA A QUANTIDADe
                }else
                {
                    menores++;
                }//FIM DO IF
            }//fim do for
            Console.WriteLine("A quantidade de pessoas maiores de idade é: {0}",maiores);
            Console.WriteLine("A quantidade de pessoas menores de idade é:{0}",menores);

        }
    }
}
