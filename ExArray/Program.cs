using System;

namespace ExArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = {7,13,4,2,7,8,90,985,87,76,48,367,38,1,18};
            int impar = 0;
            int par = 0;

                for (int i = 0; i < numeros.Length; i++) //vai repetir o verificar 15 vezes(quantidade de números na int[])
                {
                    if (numeros[i] % 2 != 0)//como o i ta na repetição, ele vai checar a "casa" q o I está
                    {
                        impar++;//a var impar começa no zero e vai aumenta cada vez q o numero for impar
                    }
                    else
                    {
                        par++;//aumenta cada vez q o numero for par
                    }
                }    
                    Console.WriteLine("\nTotal de Números:"+numeros.Length);        
                    Console.WriteLine("A quantidade de números ímpares é: "+impar);
                    Console.WriteLine("A quantidade de números pares é:"+par);

            
        }
    }
}
 