using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor1;
            float valor2;

            Console.WriteLine("\nEXERCÍCIO 1");
            Console.WriteLine("Informe o valor 1:");
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor 2 (Que não seja igual o primeiro):");
            valor2 = float.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("\nO maior valor é o valor 1:");
                Console.WriteLine(valor1);
            }else
            {
                Console.WriteLine("\nO maior valor é o valor 2:");
                Console.WriteLine(valor2);
            }
        }
    }
}
