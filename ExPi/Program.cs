using System;

namespace ExPi
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( int i=0; i<=100; i++)
            {
                if ( i % 4 == 0)
                {
                    Console.WriteLine("PI");
                }else
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
