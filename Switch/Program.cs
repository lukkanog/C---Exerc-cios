using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string passeio = "montanha";
            switch(passeio){
                case "montanha":
                    Console.WriteLine("Bora escalar");
                    break;
                case "deserto":
                    Console.WriteLine("Leva uma água");
                    break;
                case "floresta":
                    Console.WriteLine("Vai lá, Tarzan");
                    break;
                default:
                    Console.WriteLine("Vamo pro Netflix");
                    break;

            }
        }
    }
}
