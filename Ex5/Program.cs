using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            int valor3;

            Console.WriteLine("\nEXERCÍCIO 5");
            Console.WriteLine("-----------");
            Console.WriteLine("Insira o primeiro valor inteiro:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor inteiro:");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor inteiro:");
            valor3 = int.Parse(Console.ReadLine());


            if (valor1 > valor2 && valor2 > valor3)
            {
                Console.WriteLine(valor1 +valor2 +valor3);
            }

            else if (valor2 >valor1 && valor1 > valor3)
            {
                Console.WriteLine(valor2+valor1+valor3);
            }

            else if (valor3 > valor2 && valor2 > valor1)
            {
                Console.WriteLine(valor3+valor2+valor1 );
            }
            
            else
            {
                Console.WriteLine(valor3+valor1+valor2);
            }
        }
    }
}
